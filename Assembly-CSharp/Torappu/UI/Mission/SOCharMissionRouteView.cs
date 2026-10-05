using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048B1 RID: 18609
	[Token(Token = "0x20048B1")]
	public class SOCharMissionRouteView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C138 RID: 115000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C138")]
		[Address(RVA = "0x1570AC0", Offset = "0x156F6C0", VA = "0x181570AC0")]
		public void RenderRouteInfo(CharQuery charQuery, bool isAvail)
		{
		}

		// Token: 0x0601C139 RID: 115001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C139")]
		[Address(RVA = "0x1570A40", Offset = "0x156F640", VA = "0x181570A40")]
		public void OnRouted()
		{
		}

		// Token: 0x0601C13A RID: 115002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C13A")]
		[Address(RVA = "0x1570D50", Offset = "0x156F950", VA = "0x181570D50")]
		public SOCharMissionRouteView()
		{
		}

		// Token: 0x04024AE4 RID: 150244
		[Token(Token = "0x4024AE4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImg;

		// Token: 0x04024AE5 RID: 150245
		[Token(Token = "0x4024AE5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _targetImg;

		// Token: 0x04024AE6 RID: 150246
		[Token(Token = "0x4024AE6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _targetPath;

		// Token: 0x04024AE7 RID: 150247
		[Token(Token = "0x4024AE7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _targetPath2;

		// Token: 0x04024AE8 RID: 150248
		[Token(Token = "0x4024AE8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _targetItem;

		// Token: 0x04024AE9 RID: 150249
		[Token(Token = "0x4024AE9")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04024AEA RID: 150250
		[Token(Token = "0x4024AEA")]
		[FieldOffset(Offset = "0x50")]
		private SpecialOperatorBasicData m_basicData;

		// Token: 0x04024AEB RID: 150251
		[Token(Token = "0x4024AEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderRouteInfo;

		// Token: 0x04024AEC RID: 150252
		[Token(Token = "0x4024AEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRouted;

		// Token: 0x04024AED RID: 150253
		[Token(Token = "0x4024AED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
