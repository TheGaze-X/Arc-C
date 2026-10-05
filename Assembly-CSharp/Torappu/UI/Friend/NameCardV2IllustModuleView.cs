using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E0D RID: 19981
	[Token(Token = "0x2004E0D")]
	public class NameCardV2IllustModuleView : NameCardV2BaseFixedModuleView<NameCardV2IllustModuleModel>
	{
		// Token: 0x0601DDB6 RID: 122294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDB6")]
		[Address(RVA = "0x1775EB0", Offset = "0x1774AB0", VA = "0x181775EB0", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2IllustModuleModel model)
		{
		}

		// Token: 0x0601DDB7 RID: 122295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDB7")]
		[Address(RVA = "0x17761D0", Offset = "0x1774DD0", VA = "0x1817761D0")]
		public NameCardV2IllustModuleView()
		{
		}

		// Token: 0x04027933 RID: 162099
		[Token(Token = "0x4027933")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _illustContainer;

		// Token: 0x04027934 RID: 162100
		[Token(Token = "0x4027934")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CrossAppShareStartDynAssetContent _crossAppShareIllustContent;

		// Token: 0x04027935 RID: 162101
		[Token(Token = "0x4027935")]
		[FieldOffset(Offset = "0x60")]
		private UICharacterIllust m_illust;

		// Token: 0x04027936 RID: 162102
		[Token(Token = "0x4027936")]
		[FieldOffset(Offset = "0x68")]
		private UIPageListener m_pageListener;

		// Token: 0x04027937 RID: 162103
		[Token(Token = "0x4027937")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x04027938 RID: 162104
		[Token(Token = "0x4027938")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
