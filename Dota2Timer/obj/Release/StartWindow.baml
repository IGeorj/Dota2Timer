   M S B A M L   `   `   `  ���� E  ADota2Timer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Dota2Timer
Dota2Timer      Dota2Timer.StartWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Dota2Timer     -     � Title$  
Dota2Timer��$	��300��$	��500�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � Topmost .  � ShowInTaskbar .  ����  �� Opacity$	 0.4Q� �� Color$ Black��.���  � ColumnDefinitions �� �� �� �� �� 	 � RowDefinitions	 �� �� .+��� -   $��ImageHolder1��$��0��$��0��$��70���� -   
 ��Name$
 ChangeImage1��$��10(� J� Opacity$	 0.8Q�
���   �$��0q�
�������$��0��$��0��$	��100��$��30��$��	0 120 0 0q�.��Change Skill�� -   $��ImageHolder2��$��1��$��0��$��70���� -   $
 ChangeImage2��$��10(�$	 0.8Q�
���   �$��0q�
�������$��1��$��0��$	��100��$��30��$��	0 120 0 0q�.��Change Skill�� -   $��ImageHolder3��$��2��$��0��$��70���� -   $
 ChangeImage3��$��10(�$	 0.8Q�
���   �$��0q�
�������$��2��$��0��$	��100��$��30��$��	0 120 0 0q�.��Change Skill�� -   $��ImageHolder4��$��3��$��0��$��70���� -	   $
 ChangeImage4��$��10(�$	 0.8Q�
���   �$��0q�
�������$��3��$��0��$	��100��$��30��$��	0 120 0 0q�.��Change Skill�� -
   $��ImageHolder5��$��4��$��0��$��70���� -   $
 ChangeImage5��$��10(�$	 0.8Q�
���   �$��0q�
�������$��4��$��0��$	��100��$��30��$��	0 120 0 0q�.��Change Skill�� -   $��CooldownTimer1��$��0��
�������$��18(�$��Center=�$��Center=�$��0��$	��100��$��50��$��1��$��	0 0 0 100q�$��Center=�$��Center=��� -   $
 StartTimer1��$	 0.7Q�
���   �$��0q�
�������$��0��$��1��$	��100��$��50��.��Start�� -   $��CooldownTimer2��$��0��
�������$��18(�$��Center=�$��Center=�$��1��$	��100��$��50��$��1��$��	0 0 0 100q�$��Center=�$��Center=��� -   $
 StartTimer2��$	 0.7Q�
���   �$��0q�
�������$��1��$��1��$	��100��$��50��.��Start�� -   $��CooldownTimer3��$��0��
�������$��18(�$��Center=�$��Center=�$��2��$	��100��$��50��$��1��$��	0 0 0 100q�$��Center=�$��Center=��� -   $
 StartTimer3��$	 0.7Q�
���   �$��0q�
�������$��2��$��1��$	��100��$��50��.��Start�� -   $��CooldownTimer4��$��0��
�������$��18(�$��Center=�$��Center=�$��3��$	��100��$��50��$��1��$��	0 0 0 100q�$��Center=�$��Center=��� -   $
 StartTimer4��$	 0.7Q�
���   �$��0q�
�������$��3��$��1��$	��100��$��50��.��Start�� -   $��CooldownTimer5��$��0��
�������$��18(�$��Center=�$��Center=�$��4��$	��100��$��50��$��1��$��	0 0 0 100q�$��Center=�$��Center=��� -   $
 StartTimer5��$	 0.7Q�
���   �$��0q�
�������$��4��$��1��$	��100��$��50��.��Start�� -   $��LevelLabel1��$��1��$��0��$��Center=�$��Center=�$��0 80 0 0q�.��Level�� -   $��	SkillLvl1��
�������$��0q� �� SelectedIndex$ 0��$��Center=�$��Center=�$��1��$��0��$��
20 120 0 0q�.@��� $��1��$��Center=�$��Center=��� $��2��$��Center=�$��Center=��� $��3��$��Center=�$��Center=��� -   $��LevelLabel2��$��1��$��1��$��Center=�$��Center=�$��0 80 0 0q�.��Level�� -   $��	SkillLvl2��
�������$��0q�$ 0��$��Center=�$��Center=�$��1��$��1��$��
20 120 0 0q�.@��� $��1��$��Center=�$��Center=��� $��2��$��Center=�$��Center=��� $��3��$��Center=�$��Center=��� -   $��LevelLabel3��$��1��$��2��$��Center=�$��Center=�$��0 80 0 0q�.��Level�� -   $��	SkillLvl3��
�������$��0q�$ 0��$��Center=�$��Center=�$��1��$��2��$��
20 120 0 0q�.@��� $��1��$��Center=�$��Center=��� $��2��$��Center=�$��Center=��� $��3��$��Center=�$��Center=��� -   $��LevelLabel4��$��1��$��3��$��Center=�$��Center=�$��0 80 0 0q�.��Level�� -   $��	SkillLvl4��
�������$��0q�$ 0��$��Center=�$��Center=�$��1��$��3��$��
20 120 0 0q�.@��� $��1��$��Center=�$��Center=��� $��2��$��Center=�$��Center=��� $��3��$��Center=�$��Center=��� -   $��LevelLabel5��$��1��$��4��$��Center=�$��Center=�$��0 80 0 0q�.��Level�� -   $��	SkillLvl5��
�������$��0q�$ 0��$��Center=�$��Center=�$��1��$��4��$��
20 120 0 0q�.@��� $��1��$��Center=�$��Center=��� $��2��$��Center=�$��Center=��� $��3��$��Center=�$��Center=��� -    $
 CloseButton��
������ $��4��$��0��$	��Top=�$��Right=�$��55 0 0 0q����� $��Images/X.png��