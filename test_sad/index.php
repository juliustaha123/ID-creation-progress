<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP Form</title>
    <link rel="stylesheet" href="index.css">

</head>
<body>

     <div class="first-top-container">
        <h1>JMC Identification Card Request</h1>
    <div class="second-top-container">

    <form action="process_form.php" method="post">
    <div class="inner-first">
        <label for="firstname">First name </label>
        <input type="text" name="name" required>
        
        <label for="MI">MI </label>
        <input type="MI" name="MI" required>
        
        <label for="lastname">Last Name </label>
        <input type="lastname" name="lastname" required>
    </div>

    <div class="inner-second">
        <label for="studentaddress">Student Address </label>
        <input type="text" name="name" required>
        
        <label for="cpNumber">Guardian's Contact No.  </label>
        <input type="cpNumber" name="cpNumber" required>
        
        <label for="birthdate">Student's Birth Date</label>
        <input type="date" id="birthday" name="birthday">
    </div>

    <div class="submit-container">
        <input type="submit" value="Submit">
    </div>
       
    </form>
    </div>
    </div>
</body>
</html>
