using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004275 RID: 17013
	[Token(Token = "0x2004275")]
	public class SandboxV2NodePreviewSupplyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A369 RID: 107369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A369")]
		[Address(RVA = "0x131FCE0", Offset = "0x131E8E0", VA = "0x18131FCE0")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A36A RID: 107370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A36A")]
		[Address(RVA = "0x131FF60", Offset = "0x131EB60", VA = "0x18131FF60")]
		public SandboxV2NodePreviewSupplyView()
		{
		}

		// Token: 0x040212C4 RID: 135876
		[Token(Token = "0x40212C4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _supplyStroke;

		// Token: 0x040212C5 RID: 135877
		[Token(Token = "0x40212C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _supplyBkg;

		// Token: 0x040212C6 RID: 135878
		[Token(Token = "0x40212C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _supplyIcon;

		// Token: 0x040212C7 RID: 135879
		[Token(Token = "0x40212C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasSupply;

		// Token: 0x040212C8 RID: 135880
		[Token(Token = "0x40212C8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textSupply;

		// Token: 0x040212C9 RID: 135881
		[Token(Token = "0x40212C9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _alphaInSupply;

		// Token: 0x040212CA RID: 135882
		[Token(Token = "0x40212CA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _alphaNotInSupply;

		// Token: 0x040212CB RID: 135883
		[Token(Token = "0x40212CB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x040212CC RID: 135884
		[Token(Token = "0x40212CC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorLocked;

		// Token: 0x040212CD RID: 135885
		[Token(Token = "0x40212CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040212CE RID: 135886
		[Token(Token = "0x40212CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
