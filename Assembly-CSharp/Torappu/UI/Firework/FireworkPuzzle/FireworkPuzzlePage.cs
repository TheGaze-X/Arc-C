using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E62 RID: 20066
	[Token(Token = "0x2004E62")]
	public class FireworkPuzzlePage : StateEnginePage, IHotfixable
	{
		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x0601DF18 RID: 122648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DF19 RID: 122649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004644")]
		public string actId
		{
			[Token(Token = "0x601DF18")]
			[Address(RVA = "0x17AC210", Offset = "0x17AAE10", VA = "0x1817AC210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DF19")]
			[Address(RVA = "0x17AC270", Offset = "0x17AAE70", VA = "0x1817AC270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601DF1A RID: 122650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF1A")]
		[Address(RVA = "0x17AC080", Offset = "0x17AAC80", VA = "0x1817AC080", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601DF1B RID: 122651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF1B")]
		[Address(RVA = "0x17ABE80", Offset = "0x17AAA80", VA = "0x1817ABE80")]
		public FireworkData.PlateContent GetPlateContentData(string plateId)
		{
			return null;
		}

		// Token: 0x0601DF1C RID: 122652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF1C")]
		[Address(RVA = "0x17ABF30", Offset = "0x17AAB30", VA = "0x1817ABF30")]
		public Act38SideServerPuzzleInfo GetServerPuzzleInfo(string puzzleId)
		{
			return null;
		}

		// Token: 0x0601DF1D RID: 122653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF1D")]
		[Address(RVA = "0x17ABFE0", Offset = "0x17AABE0", VA = "0x1817ABFE0")]
		public List<string> GetUnlockedPuzzleIdList()
		{
			return null;
		}

		// Token: 0x0601DF1E RID: 122654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF1E")]
		[Address(RVA = "0x17ABD00", Offset = "0x17AA900", VA = "0x1817ABD00")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601DF1F RID: 122655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF1F")]
		[Address(RVA = "0x17AC1B0", Offset = "0x17AADB0", VA = "0x1817AC1B0")]
		public FireworkPuzzlePage()
		{
		}

		// Token: 0x0601DF20 RID: 122656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF20")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04027C17 RID: 162839
		[Token(Token = "0x4027C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Dictionary<string, FireworkData.PlateContent> m_puzzleData;

		// Token: 0x04027C18 RID: 162840
		[Token(Token = "0x4027C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Dictionary<string, Act38SideServerPuzzleInfo> m_puzzleInfoMap;

		// Token: 0x04027C1A RID: 162842
		[Token(Token = "0x4027C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04027C1B RID: 162843
		[Token(Token = "0x4027C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04027C1C RID: 162844
		[Token(Token = "0x4027C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04027C1D RID: 162845
		[Token(Token = "0x4027C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPlateContentData;

		// Token: 0x04027C1E RID: 162846
		[Token(Token = "0x4027C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetServerPuzzleInfo;

		// Token: 0x04027C1F RID: 162847
		[Token(Token = "0x4027C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetUnlockedPuzzleIdList;

		// Token: 0x04027C20 RID: 162848
		[Token(Token = "0x4027C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x04027C21 RID: 162849
		[Token(Token = "0x4027C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E63 RID: 20067
		[Token(Token = "0x2004E63")]
		public class Params
		{
			// Token: 0x0601DF21 RID: 122657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DF21")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04027C22 RID: 162850
			[Token(Token = "0x4027C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04027C23 RID: 162851
			[Token(Token = "0x4027C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, FireworkData.PlateContent> puzzleData;

			// Token: 0x04027C24 RID: 162852
			[Token(Token = "0x4027C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, Act38SideServerPuzzleInfo> puzzleInfoMap;
		}
	}
}
