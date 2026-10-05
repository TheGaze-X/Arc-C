using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Gacha
{
	// Token: 0x02001661 RID: 5729
	[Token(Token = "0x2001661")]
	public class PanelCharacterIllust : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06008203 RID: 33283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F71")]
		public Texture mainTexture
		{
			[Token(Token = "0x6008203")]
			[Address(RVA = "0x2B09DD0", Offset = "0x2B089D0", VA = "0x182B09DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008204")]
		[Address(RVA = "0x2B09BC0", Offset = "0x2B087C0", VA = "0x182B09BC0")]
		public void SetData(GachaController.CharacterConfig config)
		{
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008205")]
		[Address(RVA = "0x2B09AE0", Offset = "0x2B086E0", VA = "0x182B09AE0")]
		public void Reset()
		{
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008206")]
		[Address(RVA = "0x2B09D70", Offset = "0x2B08970", VA = "0x182B09D70")]
		public PanelCharacterIllust()
		{
		}

		// Token: 0x04008410 RID: 33808
		[Token(Token = "0x4008410")]
		[FieldOffset(Offset = "0x18")]
		private UICharacterIllust m_illust;

		// Token: 0x04008411 RID: 33809
		[Token(Token = "0x4008411")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainTexture;

		// Token: 0x04008412 RID: 33810
		[Token(Token = "0x4008412")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04008413 RID: 33811
		[Token(Token = "0x4008413")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04008414 RID: 33812
		[Token(Token = "0x4008414")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
