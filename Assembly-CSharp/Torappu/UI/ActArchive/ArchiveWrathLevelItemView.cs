using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C60 RID: 27744
	[Token(Token = "0x2006C60")]
	public class ArchiveWrathLevelItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D94 RID: 23956
		// (get) Token: 0x0602799B RID: 162203 RVA: 0x000CED30 File Offset: 0x000CCF30
		[Token(Token = "0x17005D94")]
		public int level
		{
			[Token(Token = "0x602799B")]
			[Address(RVA = "0x22C8D10", Offset = "0x22C7910", VA = "0x1822C8D10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602799C RID: 162204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602799C")]
		[Address(RVA = "0x22C8BF0", Offset = "0x22C77F0", VA = "0x1822C8BF0")]
		public void Render(WrathLevelModel levelModel)
		{
		}

		// Token: 0x0602799D RID: 162205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602799D")]
		[Address(RVA = "0x22C8CB0", Offset = "0x22C78B0", VA = "0x1822C8CB0")]
		public ArchiveWrathLevelItemView()
		{
		}

		// Token: 0x0403829F RID: 230047
		[Token(Token = "0x403829F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x040382A0 RID: 230048
		[Token(Token = "0x40382A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelDesc;

		// Token: 0x040382A1 RID: 230049
		[Token(Token = "0x40382A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _level;

		// Token: 0x040382A2 RID: 230050
		[Token(Token = "0x40382A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x040382A3 RID: 230051
		[Token(Token = "0x40382A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040382A4 RID: 230052
		[Token(Token = "0x40382A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
