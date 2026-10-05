using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200668B RID: 26251
	[Token(Token = "0x200668B")]
	public class HandBookAvgView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700594D RID: 22861
		// (get) Token: 0x06025B37 RID: 154423 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025B38 RID: 154424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700594D")]
		public Action<string> onClick
		{
			[Token(Token = "0x6025B37")]
			[Address(RVA = "0x208E620", Offset = "0x208D220", VA = "0x18208E620")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025B38")]
			[Address(RVA = "0x208E680", Offset = "0x208D280", VA = "0x18208E680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025B39 RID: 154425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B39")]
		[Address(RVA = "0x208E390", Offset = "0x208CF90", VA = "0x18208E390")]
		public void RenderView(int currentCount, int totalCount, HandbookAvgData data, string charId)
		{
		}

		// Token: 0x06025B3A RID: 154426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B3A")]
		[Address(RVA = "0x208E2B0", Offset = "0x208CEB0", VA = "0x18208E2B0")]
		public void OnClick()
		{
		}

		// Token: 0x06025B3B RID: 154427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B3B")]
		[Address(RVA = "0x208E5C0", Offset = "0x208D1C0", VA = "0x18208E5C0")]
		public HandBookAvgView()
		{
		}

		// Token: 0x04034F65 RID: 216933
		[Token(Token = "0x4034F65")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04034F66 RID: 216934
		[Token(Token = "0x4034F66")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04034F67 RID: 216935
		[Token(Token = "0x4034F67")]
		[FieldOffset(Offset = "0x28")]
		private HandbookAvgData m_cacheData;

		// Token: 0x04034F68 RID: 216936
		[Token(Token = "0x4034F68")]
		[FieldOffset(Offset = "0x30")]
		private string m_cacheCharId;

		// Token: 0x04034F6A RID: 216938
		[Token(Token = "0x4034F6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04034F6B RID: 216939
		[Token(Token = "0x4034F6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04034F6C RID: 216940
		[Token(Token = "0x4034F6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04034F6D RID: 216941
		[Token(Token = "0x4034F6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04034F6E RID: 216942
		[Token(Token = "0x4034F6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
