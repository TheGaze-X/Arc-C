using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DE0 RID: 19936
	[Token(Token = "0x2004DE0")]
	public class NameCardV2ShareSignRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DCE7 RID: 122087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCE7")]
		[Address(RVA = "0x17676A0", Offset = "0x17662A0", VA = "0x1817676A0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DCE8 RID: 122088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCE8")]
		[Address(RVA = "0x1767890", Offset = "0x1766490", VA = "0x181767890")]
		public NameCardV2ShareSignRemakeLayoutElement()
		{
		}

		// Token: 0x04027785 RID: 161669
		[Token(Token = "0x4027785")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _resumeIcon;

		// Token: 0x04027786 RID: 161670
		[Token(Token = "0x4027786")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgRect;

		// Token: 0x04027787 RID: 161671
		[Token(Token = "0x4027787")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _resumeText;

		// Token: 0x04027788 RID: 161672
		[Token(Token = "0x4027788")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x04027789 RID: 161673
		[Token(Token = "0x4027789")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
