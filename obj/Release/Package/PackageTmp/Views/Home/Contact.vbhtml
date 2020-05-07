@Code
    ViewData("Title") = "Contact"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>

<div style="width:30%; height:130px; margin-left: auto; margin-right: auto;">
    <img src="https://indiawebdesigns.in/wp-content/uploads/2017/10/support.gif" width="100%" alt="" />
</div>

<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title="Phone">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong>   <a href="mailto:sbrooks@clear-web-designs.com">sbrooks@clear-web-designs.com</a><br />
    <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
</address>

<form method="post" action="#" style="margin-bottom:40px;">
    <div class="form-group-lg">
        <label>Name:</label>
        <input type="text" value="name" autofocus /> <br />
        <label>Email:</label> 
        <input type="email" value="email" /> <br />
        <textarea name="message" cols="60" rows="5" spellcheck="true" maxlength="255"></textarea> <br />
        <input type="submit" value="submit" />
    </div>
</form>
