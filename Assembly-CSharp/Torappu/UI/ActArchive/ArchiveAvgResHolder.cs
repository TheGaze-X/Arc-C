using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B11 RID: 27409
	[Token(Token = "0x2006B11")]
	public class ArchiveAvgResHolder : MonoBehaviour, IActArchiveSubResHolder, IHotfixable
	{
		// Token: 0x17005C9D RID: 23709
		// (get) Token: 0x0602730E RID: 160526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C9D")]
		public Sprite avgTitle
		{
			[Token(Token = "0x602730E")]
			[Address(RVA = "0x22563F0", Offset = "0x2254FF0", VA = "0x1822563F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602730F RID: 160527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602730F")]
		[Address(RVA = "0x2256390", Offset = "0x2254F90", VA = "0x182256390")]
		public ArchiveAvgResHolder()
		{
		}

		// Token: 0x04037707 RID: 227079
		[Token(Token = "0x4037707")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("AVG Image")]
		private Sprite _avgTitle;

		// Token: 0x04037708 RID: 227080
		[Token(Token = "0x4037708")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgTitle;

		// Token: 0x04037709 RID: 227081
		[Token(Token = "0x4037709")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
