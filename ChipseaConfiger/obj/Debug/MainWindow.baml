   M S B A M L   `   `   `  ����J  FChipseaConfiger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ChipseaConfigerChipseaConfiger  5   	        ChipseaConfiger.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ChipseaConfiger     5   	   ` \ICSharpCode.AvalonEdit, Version=4.3.1.9429, Culture=neutral, PublicKeyToken=9cc39be672370310?
avalonedit.http://icsharpcode.net/sharpdevelop/avalonedit  5   	   -   5          � Title$  ChipseaConfiger��5	   	   $	��730��6!   $	��600��6.   ���	#FF635E5E.��5
      � -   5        $��
GridWindow��5
       � ColumnDefinitions 5   
   �� 5      $	��41* �6   �� 5      $	��42* �6    � RowDefinitions 5   
   �� 5      $��27 �6   �� 5      �� 5      -   5         �Name$ RowStatusBar��5   (   $��20 �6   6(   .+�5   
   ]� $��2��6   ���	#FFBBB5B5.+�5      o� -   5         o�Name$
 menu��5      ���	#FFB2AFAF$	��Top=�68   $	��0,2q�6M   .@�5      m� $��_File��6   .@�5      m� -   5        $��	_New File��5      62   m� 5      -   5        $��
_Open File��5      63   m� 5      -   5        $��_New View into File��5      6]   m� 5      -   5        $��_Save ��5      6/   m� 5      $��_Save As...��6   m� 5      $��_Close File��6   m� 5      $��_Exit��6   5      m� 5      $
��Find��6   $��7,1,8,1q�6)   .@�5       m� $��	_Find ...��6   m� 5!      $��
_Find Next��6   m� 5"      $��_Find Previous��6   m� 5#      $��_Replace ...��6   5$      m� 5%      $��_Edit��6   $��7,1,8,1q�6*   .@�5&      m� $
��_Cut��6   m� 5'      $��_Copy��6   m� 5(      $��_Paste��6   m� 5)      $��_Undo��6   m� 5*      $��_Redo��6   5+      m� 5.      $��_View��6   $��7,1,8,1q�6*   .@�5/      m� $��
_Read Only��6   65   m� 50      -	   5        $��LayoutSingleItem��50   7   $��_Single Layout��6    m� 	IsChecked . 6`   m� 51      -
   5        $��
ItemScheme��51   9   $��_MonoKai Scheme��6   6i   m� 52      -   5        $��WordWrapItem��52   2   $��	_WordWrap��6   6G   m� 53      -   5        $��LineNumberItem��53   4   $��_LineNumber��6   6J   m� 54      -   5        $��ViewSFRItem��54   2   $��	_View SFR��6   62   m� 55      -   5        $��ViewSetupResult��55   ;   $��_View Setup Result��6   6;   56      m� 57      $��Tools��6   $��7,1,8,1q�6*   .@�58      m� $��_New Snippets��6   m� 59      $��_New HighLight��6   5:      m� 5;      $��	_Language��6   $��7,1,8,1q�6.   .@�5<      m� -   5        $��AssemblyItem��5<   2   $��	_Assembly��6   62   m� 5=      -   5        $��CLanguageItem��5=   4   $��_C Language��6   64   5>      m� 5?      $��_Options��6   $��7,1,8,1q�6-   .@�5@      m� -   5        $��StatusBarItem��5@   4   $��
_StatusBar��6   6I   m� 5A      -   5        $��_TextEditor��5A      64   m� 5B      $��	_TextArea��6   m� 5C      $��_Other��6   5D      m� 5E      $��_Perioherials��6   $��7,1,8,1q�62   .@�5F      m� -   5        $��ItemSelecSoc��5F   4   $��_Select SOC��6   6H   m� 5G      -   5        $��Item_Oscillators��5G   5   $��_Oscillators��6   {�.  6M   m� 5H      -   5        $��Item_Interrupt��5H   3   $��
_Interrupt��6   {�.  6I   m� 5I      -   5        $��Item_PortIO��5I   0   $��_PortIO��6   {�.  6W   m� 5J      -   5        $��	Item_Uart��5J   /   $��_Uart��6   {�.  6@   m� 5K      -   5        $��Item_SPI��5K   .   $
��_SPI��6   {�.  6>   m� 5L      -   5        $��Item_ADC��5L   .   $
��_ADC��6   {�.  6>   m� 5M      -   5        $��Item_LCD��5M   .   $
��_LCD��6   {�.  6>   m� 5N      -   5        $��Item_LED��5N   .   $
��_LED��6   {�.  6>   m� 5O      -   5        $��Item_Timers��5O   1   $��_Timers��6   {�.  6D   m� 5P      -   5        $��
Item_Reset��5P   ;   $��_Reset All Defualt��6   {�.  6N   5Q      m� 5R      $��_Help��6   $��7,1,8,1q�6*   .@�5S      m� $��Contact��6   m� 5T      $��	ChangeLog��6   m� 5U      -   5        $��About ChipseaConfiger��5U      6>   5V      5X      5Y      � 5Z   
   -   5         �Name$ 	GridPanel��5Z      $��1��6"   ���	#FFC5C2C2$��2��6F    5[      �� 5]      -    5        $ 
ColumnLeft��5]   $   $
��600* �67   �� 5^      -!   5        $ ColumnRight��5^   $   $
��660* �67   .+�5`      �� -"   5         ��Name$ gridSplitter��5`      $��1��61   $
��Left=�6A   $��4��6\   ���	#FF8589876f   '  !ICSharpCode.AvalonEdit.TextEditor  5a      -#   5          Name$ TextEditorLeft��5a   $   	   
IsReadOnly	 . 
   ShowLineNumbers
 .    LineNumbersForeground
 �����$��0��6�   $   HorizontalScrollBarVisibility$
 Auto=�6�   "   VerticalScrollBarVisibility$
 Auto=�6�   
�������$��2q�6�     5b      -$   5        $ TextEditorRight��5b   $   
 . 
 �����$
 Auto=�6r   $
 Auto=�6�   
�������$��2q�6�   $��4,0,0,0q�6�   $��1��6�   5c      �� 5d   
   -%   5         ��Name$ 	StatusBar��5d      $��2��6'   $��2��6;   ���	#FFE4E0E06H   5e      5h      