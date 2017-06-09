import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *
clr.AddReference('System.Drawing')
from System.Drawing import Size
import math

name = 'sqRoot'
def sqRootFunction(sender, e):
    frm = sender.Tag
    frm.tbRez.Text = str(math.sqrt(float(frm.tbPrvi.Text)))

def DodajFunkciju(frm):
    operacija = ToolStripMenuItem(Text='SqRoot', Name='runSqRoot', Size=Size(130, 25))
    operacija.Tag = frm
    operacija.Click += sqRootFunction
    frm.addedOperaionsToolStripMenuItem.DropDownItems.Add(operacija)