# Algorithms1
imported from Visual Studio 2012 project




I had a bit of trouble with merging when trying to do Pete's steps. These are the steps I ended up with.

Use your OS to delete the .git folder inside of the project folder that you want to commit. This will give you a clean slate to work with. This is also a good time to make a .gitignore file inside the project folder. This can be a copy of the .gitignore created when you created the repository on github.com. Doing this copy will avoid deleting it when you update the github.com repository.
Open Git Bash and navigate to the folder you just deleted the .git folder from.
Run git init. This sets up a local repository in the folder you're in.
Run git remote add [alias] https://github.com/[gitUserName]/[RepoName].git. [alias] can be anything you want. The [alias] is meant to tie to the local repository, so the machine name works well for an [alias]. The URL can be found on github.com, along the top ensure that the HTTP button out of HTTP|SSH|Git Read-Only is clicked. The git:// URL didn't work for me.
Run git pull [alias] master. This will update your local repository and avoid some merging conflicts.
Run git add .
Run git commit -m 'first code commit'
Run git push [alias] master

