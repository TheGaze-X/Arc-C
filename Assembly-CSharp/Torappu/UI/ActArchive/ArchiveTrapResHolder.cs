using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C5D RID: 27741
	[Token(Token = "0x2006C5D")]
	public class ArchiveTrapResHolder : MonoBehaviour, IActArchiveSubResHolder, IHotfixable
	{
		// Token: 0x17005D90 RID: 23952
		// (get) Token: 0x06027989 RID: 162185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D90")]
		public Sprite trapTitle
		{
			[Token(Token = "0x6027989")]
			[Address(RVA = "0x22C7770", Offset = "0x22C6370", VA = "0x1822C7770")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602798A RID: 162186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602798A")]
		[Address(RVA = "0x22C7710", Offset = "0x22C6310", VA = "0x1822C7710")]
		public ArchiveTrapResHolder()
		{
		}

		// Token: 0x0403827B RID: 230011
		[Token(Token = "0x403827B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Relic Image")]
		private Sprite _trapTitle;

		// Token: 0x0403827C RID: 230012
		[Token(Token = "0x403827C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trapTitle;

		// Token: 0x0403827D RID: 230013
		[Token(Token = "0x403827D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
