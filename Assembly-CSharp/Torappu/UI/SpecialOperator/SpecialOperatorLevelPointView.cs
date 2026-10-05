using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E81 RID: 16001
	[Token(Token = "0x2003E81")]
	public class SpecialOperatorLevelPointView : SpecialOperatorPointViewBase
	{
		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x06018DD3 RID: 101843 RVA: 0x0009C3C0 File Offset: 0x0009A5C0
		[Token(Token = "0x17003B58")]
		public override SpecialOperatorPointViewType viewType
		{
			[Token(Token = "0x6018DD3")]
			[Address(RVA = "0x11950E0", Offset = "0x1193CE0", VA = "0x1811950E0", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x06018DD4 RID: 101844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DD4")]
		[Address(RVA = "0x1194EB0", Offset = "0x1193AB0", VA = "0x181194EB0", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06018DD5 RID: 101845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DD5")]
		[Address(RVA = "0x1195040", Offset = "0x1193C40", VA = "0x181195040")]
		public SpecialOperatorLevelPointView()
		{
		}

		// Token: 0x06018DD6 RID: 101846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DD6")]
		[Address(RVA = "0x118ED40", Offset = "0x118D940", VA = "0x18118ED40")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0401E9E9 RID: 125417
		[Token(Token = "0x401E9E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x0401E9EA RID: 125418
		[Token(Token = "0x401E9EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _inactivePartGO;

		// Token: 0x0401E9EB RID: 125419
		[Token(Token = "0x401E9EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _activePartGO;

		// Token: 0x0401E9EC RID: 125420
		[Token(Token = "0x401E9EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0401E9ED RID: 125421
		[Token(Token = "0x401E9ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401E9EE RID: 125422
		[Token(Token = "0x401E9EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
