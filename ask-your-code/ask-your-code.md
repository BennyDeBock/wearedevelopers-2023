# Ask your code - Scott Chacon

Everyone nowadays uses version control in code environments. But why do we use it?
For that we have to look at Product Design for version control. Working by the first principle we have to ask why a lot.
The first principle rest on a basic concept or assumption that we know to be true and it's not deduced from anything else.

# Why?
Why is such an important question. We all do things that seem natural to us but we never stop to ask why.

We shall learn how to use why to improve a workflow and get down to the basics of a problem.
For asking the question and explaining a why, you have to be in a framework that allows something to be true.

An example of this is listed below:
```
- We all use git
Why?

- Because we need version control
Why?

- To be able to collaborate and save our work
Why?

- Because our computer doesn't save the history of our files or allow other people to acces them
```
Out of this example, we can take that we need history saving and file access for others. This functionality is built in google docs. Does that mean that we all should use google docs then? 

**Homework**: look at anything you do in life that seems mundane and ask yourself why.


## What does version control do for us?
- It backups things - `commit`
- We can experiment - `branch`, `checkout`
- We can collaborate and review - `diff`, `merge`
- We can move bits - `push`, `pull`
- It provides **archaeology** - `log`, `blame`, `inspect`

For this talk, the focus was on the archaeology aspect and what questions these answer.

### Archaeology - What question does this answer?
#### The common questions

*"What are the last few dozen commits that are made to this codebase?"*
- `git log` | `git log --oneline --graph`

This command doesn't usually help you a lot as you want to know which changes have been made exactly, not a general overview. If we compare this to a subway map, it is the same principle. It gives you a general overview, but it isn't very clear and doesn't necessarily tell you where to go. Git commit graphs are like a subway map; They don't answer anything.

*"Who is the last person who touched this line of code?"*
- `git blame -L <from line>,<to line> <path to file>` | `git log -L <from line>,<to line>:<path to file>`

#### The uncommon questions
*"What commits are on this branch that are not yet merged into this other branch?"*
- `git log <origin branch>..<branch to compare to>` | `git log <origin branch> ^<branch to compare to>`

*"What commits introduced a change that included a specific string"*
- `git log -S <string> -p`

*"What file was this function moved from?"*
- `git blame -w -C -C -C -L <from line>,<to line> <path to file>`

*"What files are most closely related to this file?"*  
[git-related-files script](./git-related-files.sh)

#### The impossible questions
*"What pull requests contributed to this file?"*
*"What code in other repositories are related to this code?"*
*"What were the conversations (in chat or Github) my team had around this code before it was merged?"*
*"What did the author('s) reference when writing this?"*
*"What specifications was this based on?"*
*"What errors were or are commonly created by this code or code related to it that I should be aware of before changing?"*

## Ask yourself the question: *"What do you want to ask your code?"*
What frustrates you with version control/your tools? How do you want it to work?


[Slides](https://speakerdeck.com/schacon/ask-your-code)  
[Book 'Pro Git' by Scott Chacon & Ben Straub](https://git-scm.com/book)