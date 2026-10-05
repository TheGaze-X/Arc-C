using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200402B RID: 16427
	[Token(Token = "0x200402B")]
	public class SandboxCharShuffleProfessionListAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x060196D4 RID: 104148 RVA: 0x0009E010 File Offset: 0x0009C210
		[Token(Token = "0x17003C94")]
		public override int count
		{
			[Token(Token = "0x60196D4")]
			[Address(RVA = "0x12150D0", Offset = "0x1213CD0", VA = "0x1812150D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060196D5 RID: 104149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60196D5")]
		[Address(RVA = "0x1214E80", Offset = "0x1213A80", VA = "0x181214E80", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060196D6 RID: 104150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196D6")]
		[Address(RVA = "0x1215070", Offset = "0x1213C70", VA = "0x181215070")]
		public SandboxCharShuffleProfessionListAdapter()
		{
		}

		// Token: 0x0401FA73 RID: 129651
		[Token(Token = "0x401FA73")]
		[FieldOffset(Offset = "0x20")]
		public Action<ProfessionCategory> onProfessionClick;

		// Token: 0x0401FA74 RID: 129652
		[Token(Token = "0x401FA74")]
		[FieldOffset(Offset = "0x28")]
		public ProfessionCategory selectProf;

		// Token: 0x0401FA75 RID: 129653
		[Token(Token = "0x401FA75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0401FA76 RID: 129654
		[Token(Token = "0x401FA76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401FA77 RID: 129655
		[Token(Token = "0x401FA77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
