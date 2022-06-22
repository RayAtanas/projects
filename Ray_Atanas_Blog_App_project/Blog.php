<?php
$link=mysqli_connect ("localhost", "root","");
mysqli_select_db ($link, "blog_project");
$con=mysqli_connect("localhost","root","","blog_project");
if(!$con) { die(" Connection Error ");
}
$results= $con->query("SELECT name FROM category ");
?>
<!doctype html>
<html lang="en">
<head>
    <link href="Blog.css" type="text/css" rel="stylesheet">
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
<header>
    <h1>blog_app</h1>
    <a href="Home.php">Home</a>
</header>
<form name="BlogContent", action="", method="post">
<input name="Blog_Name", type="text", placeholder="Name">
    <input name="Blog_Content", type="text", placeholder="Content">

    <select name="Cat_name">
<?php
while($rows=$results->fetch_assoc()) {
    $name = $rows['name'];
    echo "<option value='$name'>$name<option>";
}

?>
    </select>
        <input name='submit_blog', type='submit', value='insert'>
<?php
if (isset ($_POST["submit_blog"]))
{
    mysqli_query ($link, "INSERT INTO `blog` (`name`, `Blog_category`, `Content`) VALUES ( '$_POST[Blog_Name]','$_POST[Cat_name]','$_POST[Blog_Content]')");
    header("Location: Home.php");
}

?>
</body>
</html>