## TabControlExtra
### An improved TabControl for Windows Forms (.Net)

The System.Windows.Forms TabControl provided by Microsoft in the .Net Library 
has a number of limitations that make it unpleasant to use.

This project grew out of an excellent effort by Mark Jackson on CodeProject to 
improve on the Microsoft TabControl. It was named CustomTabControl, and the 
original can be found here: 

[Painting Your Own Tabs - Second Edition](https://www.codeproject.com/Articles/91387/Painting-Your-Own-Tabs-Second-Edition)

This link includes a good description of the failings of Microsoft's TabControl,
and describes in detail the approach taken by Mark to improve it.

In 2011 I found a need for a tab control that avoids the limitations of the 
Microsoft TabControl, and I came across Mark's CustomTabControl at the link 
above. 

Mark's code dates back to 2010, and there have been no updates since then, and I
discovered a number of bugs that needed to be fixed. I also wanted some 
additional customizations (for example flat rectangular tabs). So I spent quite a bit
of time over the years since then modifying it to meet my needs.

I have a number of projects that I want to publish on GitHub that use my 
modified version, and although the CodeProject Open Licence (under which Mark's 
code was licensed) would permit me to do this, I feel strongly that such a 
useful component should be more easily and widely accessible and should therefore 
be a free-standing project on GitHub in its own right.

Hence this project. I have renamed it to TabControl-Extra, rather than its 
original name, CustomTabControl. 

The initial source code in the repository is Mark's code that I downloaded in 
2011, and my accumulated amendments are in subsequent commits. So the gross 
history of the project is represented in the repository, though not the 
detailed process of my amendments (ie there are not separate commits for all
the various bug fixes and enhancements I made up to the creation of this 
repository).

### Licence

This project is licensed under the Code Project Open License (CPOL) Version 1.02
(see the [License.md](https://github.com/tradewright/tabcontrol-extra/blob/master/License.md) file or go [here](https://www.codeproject.com/info/cpol10.aspx)).
