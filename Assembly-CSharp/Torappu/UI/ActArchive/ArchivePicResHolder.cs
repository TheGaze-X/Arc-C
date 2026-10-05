using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BE5 RID: 27621
	[Token(Token = "0x2006BE5")]
	public class ArchivePicResHolder : MonoBehaviour, IActArchiveSubResHolder, IHotfixable
	{
		// Token: 0x17005D1C RID: 23836
		// (get) Token: 0x06027717 RID: 161559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D1C")]
		public Sprite picTitle
		{
			[Token(Token = "0x6027717")]
			[Address(RVA = "0x229B490", Offset = "0x229A090", VA = "0x18229B490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D1D RID: 23837
		// (get) Token: 0x06027718 RID: 161560 RVA: 0x000CE6A0 File Offset: 0x000CC8A0
		[Token(Token = "0x17005D1D")]
		public bool useBkg
		{
			[Token(Token = "0x6027718")]
			[Address(RVA = "0x229B4F0", Offset = "0x229A0F0", VA = "0x18229B4F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027719 RID: 161561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027719")]
		[Address(RVA = "0x229B430", Offset = "0x229A030", VA = "0x18229B430")]
		public ArchivePicResHolder()
		{
		}

		// Token: 0x04037E20 RID: 228896
		[Token(Token = "0x4037E20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Pic Image")]
		private Sprite _picTitle;

		// Token: 0x04037E21 RID: 228897
		[Token(Token = "0x4037E21")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Pic Image")]
		private bool _useBkg;

		// Token: 0x04037E22 RID: 228898
		[Token(Token = "0x4037E22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_picTitle;

		// Token: 0x04037E23 RID: 228899
		[Token(Token = "0x4037E23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_useBkg;

		// Token: 0x04037E24 RID: 228900
		[Token(Token = "0x4037E24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
