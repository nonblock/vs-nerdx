# VsNerdX (2.4.0)
[NERDTree](https://github.com/scrooloose/nerdtree) inspired Solution Explorer for Visual Studio. It integrates VIM bindings for tree navigation and manipulation into Visual Studio's hierarchy windows.

### Fork : Youngjoon Kim (nonblock@gmail.com)
[nonblock/vs-nerdx](https://github.com/nonblock/vs-nerdx)

Modified many shortcuts and actions in a more intuitive way as a nerd using VIM for 25+ years.

# Install
If building from source, use the resulting `VsNerdX.vsix`.
Currently supported Visual Studio versions are 2017, 2019, and 2022. 

# Usage
#### Navigation
* `j` - go up
* `k` - go down
* `h` - go to parent or fold (much like left arrow)
* `l` - unfold or go to the first child (much like right arrow)
* `ctrl+b` - 16 lines up
* `ctrl+f` - 16 lines down
* `ctrl+u` - 8 lines up
* `ctrl+d` - 8 lines down
* `1` or `H` - go to top
* `G` or `L` - go to bottom
* `o` - unfold
* `J` - fold 
* `%` - togge between the last and first sibling

# ETC (to review)
#### File node mappings
* `<Enter>` - open file
* `go` - preview file
* `i` - open split
* `s` - open vertical split

#### Tree navigation mappings
* `gg` - go to top

#### Node editing mappings
* `dd` - delete 
* `cc` - cut 
* `yy` - copy 
* `yp` - copy full path
* `yw` - copy visible text
* `p` - paste 
* `r` - rename

#### Tree filtering mappings
* `I` - toggle show all files 

#### Other mappings
* `/` - enter find mode - stops all processing of keys with the exception of Esc
* `Esc` - exit find mode - resumes handling of navigation keys
* `?` - toggle help

# Providing Feedback
* File a bug or request a new feature in [issue tracker](https://github.com/mstevius/vs-nerdx/issues).
* [Tweet](https://twitter.com/stevium) me  with any other feedback.
