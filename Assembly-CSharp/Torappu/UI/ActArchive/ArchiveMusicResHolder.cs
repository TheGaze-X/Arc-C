using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BC0 RID: 27584
	[Token(Token = "0x2006BC0")]
	public class ArchiveMusicResHolder : MonoBehaviour, IActArchiveSubResHolder, IHotfixable
	{
		// Token: 0x17005D01 RID: 23809
		// (get) Token: 0x06027651 RID: 161361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D01")]
		public Sprite musicTitle
		{
			[Token(Token = "0x6027651")]
			[Address(RVA = "0x2294B30", Offset = "0x2293730", VA = "0x182294B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D02 RID: 23810
		// (get) Token: 0x06027652 RID: 161362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D02")]
		public Sprite cdLeft
		{
			[Token(Token = "0x6027652")]
			[Address(RVA = "0x2294A10", Offset = "0x2293610", VA = "0x182294A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D03 RID: 23811
		// (get) Token: 0x06027653 RID: 161363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D03")]
		public Sprite cdLeftLogo
		{
			[Token(Token = "0x6027653")]
			[Address(RVA = "0x22949B0", Offset = "0x22935B0", VA = "0x1822949B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D04 RID: 23812
		// (get) Token: 0x06027654 RID: 161364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D04")]
		public Sprite cdRight
		{
			[Token(Token = "0x6027654")]
			[Address(RVA = "0x2294AD0", Offset = "0x22936D0", VA = "0x182294AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D05 RID: 23813
		// (get) Token: 0x06027655 RID: 161365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D05")]
		public Sprite cdRightLogo
		{
			[Token(Token = "0x6027655")]
			[Address(RVA = "0x2294A70", Offset = "0x2293670", VA = "0x182294A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027656 RID: 161366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027656")]
		[Address(RVA = "0x2294950", Offset = "0x2293550", VA = "0x182294950")]
		public ArchiveMusicResHolder()
		{
		}

		// Token: 0x04037CF6 RID: 228598
		[Token(Token = "0x4037CF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Music Image")]
		private Sprite _musicTitle;

		// Token: 0x04037CF7 RID: 228599
		[Token(Token = "0x4037CF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Music Image")]
		private Sprite _cdLeft;

		// Token: 0x04037CF8 RID: 228600
		[Token(Token = "0x4037CF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Music Image")]
		private Sprite _cdLeftLogo;

		// Token: 0x04037CF9 RID: 228601
		[Token(Token = "0x4037CF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Music Image")]
		private Sprite _cdRight;

		// Token: 0x04037CFA RID: 228602
		[Token(Token = "0x4037CFA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Music Image")]
		private Sprite _cdRightLogo;

		// Token: 0x04037CFB RID: 228603
		[Token(Token = "0x4037CFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_musicTitle;

		// Token: 0x04037CFC RID: 228604
		[Token(Token = "0x4037CFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cdLeft;

		// Token: 0x04037CFD RID: 228605
		[Token(Token = "0x4037CFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cdLeftLogo;

		// Token: 0x04037CFE RID: 228606
		[Token(Token = "0x4037CFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cdRight;

		// Token: 0x04037CFF RID: 228607
		[Token(Token = "0x4037CFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cdRightLogo;

		// Token: 0x04037D00 RID: 228608
		[Token(Token = "0x4037D00")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
