using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BE9 RID: 27625
	[Token(Token = "0x2006BE9")]
	public class ArchiveQuestCgContentDataBinder : DataBinder<ArchiveQuestProperty>
	{
		// Token: 0x0602772B RID: 161579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602772B")]
		[Address(RVA = "0x229C3D0", Offset = "0x229AFD0", VA = "0x18229C3D0", Slot = "7")]
		public override void OnValueChanged(ArchiveQuestProperty property)
		{
		}

		// Token: 0x0602772C RID: 161580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602772C")]
		[Address(RVA = "0x229C4E0", Offset = "0x229B0E0", VA = "0x18229C4E0")]
		private void RefreshImage(SandboxV2ArchiveQuestCgData cgData)
		{
		}

		// Token: 0x0602772D RID: 161581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602772D")]
		[Address(RVA = "0x229C7B0", Offset = "0x229B3B0", VA = "0x18229C7B0")]
		private string _GetCgPath(string cgPath)
		{
			return null;
		}

		// Token: 0x0602772E RID: 161582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602772E")]
		[Address(RVA = "0x229C860", Offset = "0x229B460", VA = "0x18229C860")]
		public ArchiveQuestCgContentDataBinder()
		{
		}

		// Token: 0x04037E4A RID: 228938
		[Token(Token = "0x4037E4A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _mainImg;

		// Token: 0x04037E4B RID: 228939
		[Token(Token = "0x4037E4B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _mainImgLoader;

		// Token: 0x04037E4C RID: 228940
		[Token(Token = "0x4037E4C")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedCgId;

		// Token: 0x04037E4D RID: 228941
		[Token(Token = "0x4037E4D")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_tween;

		// Token: 0x04037E4E RID: 228942
		[Token(Token = "0x4037E4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037E4F RID: 228943
		[Token(Token = "0x4037E4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshImage;

		// Token: 0x04037E50 RID: 228944
		[Token(Token = "0x4037E50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetCgPath;

		// Token: 0x04037E51 RID: 228945
		[Token(Token = "0x4037E51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
