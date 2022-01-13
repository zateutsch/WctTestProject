## WctTestProject
Test scenarios for the Windows Community Toolkit, stored for reference purposes.

# Hacky Workaround for Virtualization Bug in WinUI TwoPaneView
### January 13th, 2022

### Problem:
Current WinUI TwoPaneView control disables virtualization of child elements because of grid implementation in their control. Pane1 is placed in a grid row with a dimension of "Auto," 
which reads as infinite size, preventing virtualization from properly occuring.

### Fix:
Only way to fix is to give intended-virtualized element a set height and width. Can't do this in custom controls.
Workaround was to set maxheight to the size of the window, and register to update on TwoPaneViews size change effect.
This doesn't restore perfect virtualization, but still shows HUGE performance boost over none at all.
