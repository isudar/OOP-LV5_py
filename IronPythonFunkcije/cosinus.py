import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *
clr.AddReference('System.Drawing')
from System.Drawing import Size
import math

name = 'cosinus'

def cosFunction(sender, e):
    frm = sender.Tag
    frm.tbRez.Text = str(math.cos(float(frm.tbPrvi.Text)))

def DodajFunkciju(frm):
    operacija = ToolStripMenuItem(Text='Cosinus', Name='runCos', Size=Size(130, 25))
    operacija.Tag = frm
    operacija.Click += cosFunction
    frm.addedOperaionsToolStripMenuItem.DropDownItems.Add(operacija)