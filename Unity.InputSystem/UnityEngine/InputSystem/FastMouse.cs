using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	internal class FastMouse : Mouse, IInputStateCallbackReceiver, IEventMerger
	{
		// Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x5686DF0", Offset = "0x56859F0", VA = "0x185686DF0")]
		public FastMouse()
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x5684030", Offset = "0x5682C30", VA = "0x185684030")]
		private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x5682380", Offset = "0x5680F80", VA = "0x185682380")]
		private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x56855B0", Offset = "0x56841B0", VA = "0x1856855B0")]
		private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x5684760", Offset = "0x5683360", VA = "0x185684760")]
		private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x56838C0", Offset = "0x56824C0", VA = "0x1856838C0")]
		private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x56852F0", Offset = "0x5683EF0", VA = "0x1856852F0")]
		private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x5683B80", Offset = "0x5682780", VA = "0x185683B80")]
		private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x5683640", Offset = "0x5682240", VA = "0x185683640")]
		private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x5681EE0", Offset = "0x5680AE0", VA = "0x185681EE0")]
		private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x56849D0", Offset = "0x56835D0", VA = "0x1856849D0")]
		private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x5684C20", Offset = "0x5683820", VA = "0x185684C20")]
		private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x5683E30", Offset = "0x5682A30", VA = "0x185683E30")]
		private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x5683430", Offset = "0x5682030", VA = "0x185683430")]
		private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x5682160", Offset = "0x5680D60", VA = "0x185682160")]
		private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x5684280", Offset = "0x5682E80", VA = "0x185684280")]
		private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x56844F0", Offset = "0x56830F0", VA = "0x1856844F0")]
		private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x5682D20", Offset = "0x5681920", VA = "0x185682D20")]
		private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x56825B0", Offset = "0x56811B0", VA = "0x1856825B0")]
		private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x5682830", Offset = "0x5681430", VA = "0x185682830")]
		private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x5682AB0", Offset = "0x56816B0", VA = "0x185682AB0")]
		private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x5682F90", Offset = "0x5681B90", VA = "0x185682F90")]
		private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x56831E0", Offset = "0x5681DE0", VA = "0x1856831E0")]
		private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x5685F40", Offset = "0x5684B40", VA = "0x185685F40")]
		private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x56857D0", Offset = "0x56843D0", VA = "0x1856857D0")]
		private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x5685A50", Offset = "0x5684650", VA = "0x185685A50")]
		private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x5685CD0", Offset = "0x56848D0", VA = "0x185685CD0")]
		private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x56861B0", Offset = "0x5684DB0", VA = "0x1856861B0")]
		private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x5686420", Offset = "0x5685020", VA = "0x185686420")]
		private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x5684E50", Offset = "0x5683A50", VA = "0x185684E50")]
		private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x56850A0", Offset = "0x5683CA0", VA = "0x1856850A0")]
		private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent)
		{
			return null;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x56867F0", Offset = "0x56853F0", VA = "0x1856867F0")]
		protected new void OnNextUpdate()
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x5686950", Offset = "0x5685550", VA = "0x185686950")]
		protected new void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x56867F0", Offset = "0x56853F0", VA = "0x1856867F0", Slot = "22")]
		private void OnNextUpdate()
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x5686C40", Offset = "0x5685840", VA = "0x185686C40", Slot = "23")]
		private void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x56866B0", Offset = "0x56852B0", VA = "0x1856866B0")]
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x5686B00", Offset = "0x5685700", VA = "0x185686B00", Slot = "25")]
		private bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
		{
			return default(bool);
		}

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer";
	}
}
