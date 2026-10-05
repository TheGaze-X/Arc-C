using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AgeTips
{
	// Token: 0x02006659 RID: 26201
	[Token(Token = "0x2006659")]
	public class UIAgeTipsEntry : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025A18 RID: 154136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A18")]
		[Address(RVA = "0x20A1840", Offset = "0x20A0440", VA = "0x1820A1840")]
		private void Start()
		{
		}

		// Token: 0x06025A19 RID: 154137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A19")]
		[Address(RVA = "0x20A1720", Offset = "0x20A0320", VA = "0x1820A1720")]
		public void Init()
		{
		}

		// Token: 0x06025A1A RID: 154138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A1A")]
		[Address(RVA = "0x20A17B0", Offset = "0x20A03B0", VA = "0x1820A17B0")]
		public void OnDetailClicked()
		{
		}

		// Token: 0x06025A1B RID: 154139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A1B")]
		[Address(RVA = "0x20A18C0", Offset = "0x20A04C0", VA = "0x1820A18C0")]
		public UIAgeTipsEntry()
		{
		}

		// Token: 0x04034DC4 RID: 216516
		[Token(Token = "0x4034DC4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _image;

		// Token: 0x04034DC5 RID: 216517
		[Token(Token = "0x4034DC5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAgeTipsEntry.Config _config;

		// Token: 0x04034DC6 RID: 216518
		[Token(Token = "0x4034DC6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAgeTipsDetailView _detailView;

		// Token: 0x04034DC7 RID: 216519
		[Token(Token = "0x4034DC7")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04034DC8 RID: 216520
		[Token(Token = "0x4034DC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04034DC9 RID: 216521
		[Token(Token = "0x4034DC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04034DCA RID: 216522
		[Token(Token = "0x4034DCA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetailClicked;

		// Token: 0x04034DCB RID: 216523
		[Token(Token = "0x4034DCB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200665A RID: 26202
		[Token(Token = "0x200665A")]
		[Serializable]
		public struct Config
		{
			// Token: 0x04034DCC RID: 216524
			[Token(Token = "0x4034DCC")]
			[FieldOffset(Offset = "0x0")]
			public string contentUrl;

			// Token: 0x04034DCD RID: 216525
			[Token(Token = "0x4034DCD")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;
		}
	}
}
