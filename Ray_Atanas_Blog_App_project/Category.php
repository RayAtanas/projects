<?php
$link=mysqli_connect ("localhost", "root","");
mysqli_select_db ($link, "blog_project");
$con=mysqli_connect("localhost","root","","blog_project");
if(!$con) { die(" Connection Error ");
}
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link href="Category.css", rel="stylesheet", type="text/css">
</head>
<body>
<header>
    <a href="Home.php">Home</a>
    <h2>Blog_app</h2>
</header>
<form name="Category", action="", method="post">
    <input name="Category_name", type="text", placeholder="Category Name">
    <input name="Category_submit", type="submit", value="insert">
</form>
<?php
if(isset($_POST['Category_submit'])){
mysqli_query ($link, "INSERT INTO Category (name) VALUES ('$_POST[Category_name]')");
header("location:Home.php");
}
?>


</body>
</html>
