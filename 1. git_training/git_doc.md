# 1. Install git

# 2. Fork a repo
[github: fork-a-repo](https://docs.github.com/en/get-started/quickstart/fork-a-repo)

# 3. Syncing a fork
[github: syncing-a-fork](/en/pull-requests/collaborating-with-pull-requests/working-with-forks/syncing-a-fork)

# 4. See the servers
```bash
git remote -v
```
# 5. Add
create a file .gitignore next to the file .git.
Into the .gitignore, add the files and the repositories you wan tto ignore like
```
repo1
repo1/myfile1.txt
repo2/sub_repo1
```

See in VSCode or open a terminal and add files:
```bash
git add myFile1 myFolder1/myFile1
```

Or add them all without the ignored (those into the .gitignore)
```bash
git add .
```
# 6. Commit
## otherwhise:
be sure you are into the folder, then:
```bash
git commit -m "message of the commit"
```

# 7. push
## if no push possible:
try to remove:<br/>
[stakoverflow: git-easiest-way-to-reset-git-config-file](https://stackoverflow.com/questions/35853986/git-easiest-way-to-reset-git-config-file)
then </br>
link:<br/>
[youtube: How to Install and Configure Git and GitHub on Ubuntu 22.04 LTS (Linux) (2023)](https://www.youtube.com/watch?v=bc3_FL9zWWs)
```bash
git remote set-url origin https://<token>@github.com/<username>/<repo-without-.git>
```

# 8. See the commits
```bash
git log
```
 
## otherwhise:
be sure you are into the folder, then:
```bash
git push
```

# optional: local infos
go to your local git repo, then
```bash
git config --global user.name "Your Name"
git config --global user.email "your.email@example.com"
```

To see the ones you have added to your repo:
```bash
git config --local --list
```

To remove multiple values:
```bash
git config [<file-option>] --unset-all name [value_regex]
git config [<file-option>] --remove-section name
```
