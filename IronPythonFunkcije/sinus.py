import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *
clr.AddReference('System.Drawing')
from System.Drawing import Size
import math

name = 'sinus'

def sinFunction(sender, e):
    frm = sender.Tag
    frm.tbRez.Text = str(math.sin(float(frm.tbPrvi.Text)))

def DodajFunkciju(frm):
    operacija = ToolStripMenuItem(Text='Sinus', Name='runSin', Size=Size(130, 25))
    operacija.Tag = frm
    operacija.Click += sinFunction
    frm.addedOperaionsToolStripMenuItem.DropDownItems.Add(operacija)