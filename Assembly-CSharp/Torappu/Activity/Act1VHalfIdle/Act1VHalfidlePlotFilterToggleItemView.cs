using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007760 RID: 30560
	[Token(Token = "0x2007760")]
	public class Act1VHalfidlePlotFilterToggleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AEC2 RID: 175810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEC2")]
		[Address(RVA = "0x26B9BB0", Offset = "0x26B87B0", VA = "0x1826B9BB0")]
		public void Render(string actId, Act1VHalfIdlePlotFilterType selectedType)
		{
		}

		// Token: 0x0602AEC3 RID: 175811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEC3")]
		[Address(RVA = "0x26B9AC0", Offset = "0x26B86C0", VA = "0x1826B9AC0")]
		public void EventOnFilterItemClick()
		{
		}

		// Token: 0x0602AEC4 RID: 175812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEC4")]
		[Address(RVA = "0x26B9D10", Offset = "0x26B8910", VA = "0x1826B9D10")]
		public Act1VHalfidlePlotFilterToggleItemView()
		{
		}

		// Token: 0x0403DEAF RID: 253615
		[Token(Token = "0x403DEAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfIdlePlotFilterType _type;

		// Token: 0x0403DEB0 RID: 253616
		[Token(Token = "0x403DEB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _typeName;

		// Token: 0x0403DEB1 RID: 253617
		[Token(Token = "0x403DEB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedLight;

		// Token: 0x0403DEB2 RID: 253618
		[Token(Token = "0x403DEB2")]
		[FieldOffset(Offset = "0x30")]
		private Act1VHalfIdlePlotTypeData m_cachedPlotTypeData;

		// Token: 0x0403DEB3 RID: 253619
		[Token(Token = "0x403DEB3")]
		[FieldOffset(Offset = "0x38")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0403DEB4 RID: 253620
		[Token(Token = "0x403DEB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DEB5 RID: 253621
		[Token(Token = "0x403DEB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnFilterItemClick;

		// Token: 0x0403DEB6 RID: 253622
		[Token(Token = "0x403DEB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
