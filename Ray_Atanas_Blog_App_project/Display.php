<?php
$link=mysqli_connect ("localhost", "root","");
mysqli_select_db ($link, "blog_project");
$con=mysqli_connect("localhost","root","","blog_project");
if(!$con) { die(" Connection Error ");
}
$results= $con->query("SELECT name FROM category ");
?>
<head>
    <link href="design.css", rel="stylesheet", type="text/css">
</head>
<header>
    <h1>Display Content</h1>
    <a href="Home.php">Home</a>
</header>
<br><br>

<?php
$a=mysqli_query($con,"SELECT * FROM Blog WHERE id='$_GET[Id]'");
$b=mysqli_fetch_array($a,MYSQLI_ASSOC)
?>
<form method="post">
    Name : <input type="text" name="name" placeholder="Insert Name" value="<?= $b['name']; ?>"><br><br>
    content : <input type="" name="content" placeholder="Insert your content" value="<?= $b['Content'];?>"><br><br>
    Category: <input type="" name="content" placeholder="Insert your content" value="<?= $b['Blog_category'];?>"><br><br>
    <br><br>

</form>

