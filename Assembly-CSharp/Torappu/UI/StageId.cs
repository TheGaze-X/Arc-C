using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B6D RID: 15213
	[Token(Token = "0x2003B6D")]
	[LuaCallCSharp(GenFlag.No)]
	public struct StageId
	{
		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x06017DC1 RID: 97729 RVA: 0x00098748 File Offset: 0x00096948
		// (set) Token: 0x06017DC2 RID: 97730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170038F9")]
		public SpecialStageType stageSelectType
		{
			[Token(Token = "0x6017DC1")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return SpecialStageType.NORMAL;
			}
			[Token(Token = "0x6017DC2")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x06017DC3 RID: 97731 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017DC4 RID: 97732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170038FA")]
		public string normalStageId
		{
			[Token(Token = "0x6017DC3")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6017DC4")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x06017DC5 RID: 97733 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017DC6 RID: 97734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170038FB")]
		public string specialStageId
		{
			[Token(Token = "0x6017DC5")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6017DC6")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x06017DC7 RID: 97735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038FC")]
		public string selectedStageId
		{
			[Token(Token = "0x6017DC7")]
			[Address(RVA = "0x101D1B0", Offset = "0x101BDB0", VA = "0x18101D1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017DC8 RID: 97736 RVA: 0x00098760 File Offset: 0x00096960
		[Token(Token = "0x6017DC8")]
		[Address(RVA = "0x101CFD0", Offset = "0x101BBD0", VA = "0x18101CFD0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06017DC9 RID: 97737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DC9")]
		[Address(RVA = "0x101D120", Offset = "0x101BD20", VA = "0x18101D120")]
		public StageId(string normalId, string specialStageId, SpecialStageType stageSelectType)
		{
		}

		// Token: 0x0401CD46 RID: 118086
		[Token(Token = "0x401CD46")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StageId EMPTY;
	}
}
