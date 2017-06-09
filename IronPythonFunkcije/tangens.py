import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *
clr.AddReference('System.Drawing')
from System.Drawing import Size
import math

name = 'tangens'

def tanFunction(sender, e):
    frm = sender.Tag
    frm.tbRez.Text = str(math.tan(float(frm.tbPrvi.Text)))

def DodajFunkciju(frm):
    operacija = ToolStripMenuItem(Text='Tangens', Name='runTan', Size=Size(130, 25))
    operacija.Tag = frm
    operacija.Click += tanFunction
    frm.addedOperaionsToolStripMenuItem.DropDownItems.Add(operacija)