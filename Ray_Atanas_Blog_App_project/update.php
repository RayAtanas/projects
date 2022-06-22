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

<header><h1>Edit Blog</h1></header>
<?php
$a=mysqli_query($con,"SELECT * FROM Blog WHERE Id='$_GET[Id]'");
$b=mysqli_fetch_array($a,MYSQLI_ASSOC)
?>
<form method="post">
    Name : <input type="text" name="name" placeholder="Insert Name" value="<?= $b['name']; ?>"><br><br>
    content : <input type="text" name="content" id="Content" placeholder="Insert your content" value="<?= $b['Content'];?>"><br><br>

    <input name="update", type="submit", placeholder="update", value="Update">
    <br><br>

</form>
<?php
if(isset($_POST['update'])) {

    $name = $_POST['name'];
    $content = $_POST['content'];

    $sql = "UPDATE Blog SET name='$name',content='$content' WHERE Id='$_GET[Id]'";
    header("Location: Home.php");

    if($con->query($sql) === false)
    {
        trigger_error('Wrong SQL Command: ' . $sql . ' Error: ' . $con->error, E_USER_ERROR);

    }

}

?>   