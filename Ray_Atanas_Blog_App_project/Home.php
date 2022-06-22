<?php
$link=mysqli_connect ("localhost", "root","");
mysqli_select_db ($link, "blog_project");
$con=mysqli_connect("localhost","root",'',"blog_project");
if(!$con) { die(" Connection Error ");
}
$results= $con->query("SELECT name FROM category ");
?>
<head>
    <link href="Home.css", rel="stylesheet", type="text/css">

</head>

    <header>
        <h1>blog_app</h1>
        <a href="Category.php", style="position: relative", id="Category">Category</a>
        <a href="Blog.php", id="Blog">Add Blog</a>
    </header>
    <table border="">
        <tbody>
        <tr>

            <th>Title</th>
            <th>Category</th>
            <th>Action</th>
        </tr>
        <?php
        $a=mysqli_query($con,"SELECT * FROM blog");
        foreach ($a as $b)
        {
            ?>
            <tr>

                <td><?= $b['name']; ?></td>
                <td><?= $b['Blog_category']; ?></td>
                <td>
                    <a href="update.php?Id=<?= $b['Id']; ?>"><b><i>Edit</i></b></a> |
                    <a href="Home.php?Id=<?= $b['Id']; ?>" ><b><i>Delete</i></b></a>
                    <a href="Display.php?Id=<?= $b['Id']; ?>" ><b><i>Display</i></b></a>
                </td>
            </tr>
        <?php } ?>
        </tbody>
    </table>


<?php
if(isset($_GET['Id']))
{
    $Id=$_GET['Id'];
    $sql="DELETE FROM blog WHERE Id='$Id'";
    if($con->query($sql) === false)
    {
        trigger_error('Wrong SQL Command: ' . $sql . ' Error: ' . $con->error, E_USER_ERROR);
    }

}

?>