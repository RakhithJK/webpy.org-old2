# ČKD

99. **Jak použiji šablony template.py**

    Pro základní dokumentaci a nějaké ukázky kódu, se podívej na [[templetor|template.py dokumentaci]]

    To display your page from inside a web.py app, just do

            homepage = template.Template(open("homepage.tmpl").read())
            print homepage()

    
99. **Why are the urls just one long list?**

    If they were a dictionary, they wouldn't be ordered. If it was a list of tuples, then it'd be a lot more typing.

99. **How do I serve static files such as JavaScripts or images like PNG and JPG with the web.py server?**

    Create a directory (also known as a folder) called `static` in the location of the script that runs the web.py server. Then place the static files you wish to server in the `static` folder. For example, the URL `http://localhost/static/logo.png` will send the image `./static/logo.png` to the client.

99. **Kam se mohu obrátit pro další pomoc?**

    Google Groups má [skupinu web.py](http://groups.google.com/group/webpy) která je docela užitečná.

99. **Jak můžu změnit výchozí "not found" stránku?**

    Můžete napsat svůj vlastní notfound handler a připojit ho k  web.webapi.notfound

            def my_notfound(): 
                print "MY OWN NOT FOUND" 
            web.webapi.notfound = my_notfound 

99. **How can i get auto completion in python after loading the webpy module?**

    In IPython, after importing webpy auto completion may no longer work. You can still use 'python' with auto completion feature. Try it out directly. Fire up 'python':

            import readline, rlcompleter; readline.parse_and_bind("tab: complete")

    and tab it! :-)

    To make in sort that this will be run default when you fire up 'python'. Make a file called '~/.pythonstartup.py' and put the import line in it. Then set the 'PYTHONSTARTUP' environment variable to point to that file.

    With my bash, i do it like following; edit ~/.bashrc and add:

            export PYTHONSTARTUP=~/.pythonstartup.py

99. **Why can't I access the database?**

    If you're trying to access the database from a non-web-serving thread (e.g. you created a new thread or you never started serving web pages) then you need to run `web.load()`. Sorry, this will be fixed in web.py 0.3.

99. **Can I iterate over an IterBetter multiple times?**

    No. Do `ib = list(ib)` first to turn it from an IterBetter into a list.

99. **How do I debug print to the console?**

	web.debug("I will get printed to the console and not the body of the webpage")

99. **I stumbled over a bug in web.py. Where can I file it?**

	Go to the [webpy launchpad site](https://launchpad.net/webpy), login (or register if you have to) and click on "report a bug".