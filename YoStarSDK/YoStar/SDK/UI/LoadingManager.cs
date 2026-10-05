using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UI
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	public class LoadingManager
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		public static LoadingManager Instance
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x5C4D630", Offset = "0x5C4C230", VA = "0x185C4D630")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x5C4D4D0", Offset = "0x5C4C0D0", VA = "0x185C4D4D0")]
		public Task ShowLoadingAsync()
		{
			return null;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x5C4D410", Offset = "0x5C4C010", VA = "0x185C4D410")]
		public void HideLoading()
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoadingManager()
		{
		}

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x0")]
		private static LoadingManager _instance;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x10")]
		private GameObject loadingPanel;
	}
}
