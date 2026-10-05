using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E48 RID: 15944
	[Token(Token = "0x2003E48")]
	public class SpecialOperatorDiagramLineModel : IHotfixable
	{
		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x06018C56 RID: 101462 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018C57 RID: 101463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AFA")]
		public List<string> startPointList
		{
			[Token(Token = "0x6018C56")]
			[Address(RVA = "0x1179C20", Offset = "0x1178820", VA = "0x181179C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018C57")]
			[Address(RVA = "0x1179DE0", Offset = "0x11789E0", VA = "0x181179DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x06018C58 RID: 101464 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018C59 RID: 101465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AFB")]
		public List<string> endPointList
		{
			[Token(Token = "0x6018C58")]
			[Address(RVA = "0x1179B50", Offset = "0x1178750", VA = "0x181179B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018C59")]
			[Address(RVA = "0x1179CF0", Offset = "0x11788F0", VA = "0x181179CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x06018C5A RID: 101466 RVA: 0x0009BA78 File Offset: 0x00099C78
		// (set) Token: 0x06018C5B RID: 101467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AFC")]
		public Vector2 startPos
		{
			[Token(Token = "0x6018C5A")]
			[Address(RVA = "0x1179C80", Offset = "0x1178880", VA = "0x181179C80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6018C5B")]
			[Address(RVA = "0x1179E60", Offset = "0x1178A60", VA = "0x181179E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x06018C5C RID: 101468 RVA: 0x0009BA90 File Offset: 0x00099C90
		// (set) Token: 0x06018C5D RID: 101469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AFD")]
		public Vector2 endPos
		{
			[Token(Token = "0x6018C5C")]
			[Address(RVA = "0x1179BB0", Offset = "0x11787B0", VA = "0x181179BB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6018C5D")]
			[Address(RVA = "0x1179D70", Offset = "0x1178970", VA = "0x181179D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06018C5E RID: 101470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C5E")]
		[Address(RVA = "0x1179840", Offset = "0x1178440", VA = "0x181179840")]
		public void LoadData(SpecialOperatorLinePosData lineData, SpecialOperatorLineRelationData lineRelationData)
		{
		}

		// Token: 0x06018C5F RID: 101471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C5F")]
		[Address(RVA = "0x1179AF0", Offset = "0x11786F0", VA = "0x181179AF0")]
		public SpecialOperatorDiagramLineModel()
		{
		}

		// Token: 0x0401E727 RID: 124711
		[Token(Token = "0x401E727")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_startPointList;

		// Token: 0x0401E728 RID: 124712
		[Token(Token = "0x401E728")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_startPointList;

		// Token: 0x0401E729 RID: 124713
		[Token(Token = "0x401E729")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_endPointList;

		// Token: 0x0401E72A RID: 124714
		[Token(Token = "0x401E72A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_endPointList;

		// Token: 0x0401E72B RID: 124715
		[Token(Token = "0x401E72B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_startPos;

		// Token: 0x0401E72C RID: 124716
		[Token(Token = "0x401E72C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_startPos;

		// Token: 0x0401E72D RID: 124717
		[Token(Token = "0x401E72D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_endPos;

		// Token: 0x0401E72E RID: 124718
		[Token(Token = "0x401E72E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_endPos;

		// Token: 0x0401E72F RID: 124719
		[Token(Token = "0x401E72F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401E730 RID: 124720
		[Token(Token = "0x401E730")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
