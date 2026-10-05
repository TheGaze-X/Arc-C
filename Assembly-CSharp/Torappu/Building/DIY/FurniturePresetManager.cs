using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018AF RID: 6319
	[Token(Token = "0x20018AF")]
	public class FurniturePresetManager : IDIYPresetManager, IDIYPresetProvider
	{
		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x0003E448 File Offset: 0x0003C648
		[Token(Token = "0x17001228")]
		public int slotCount
		{
			[Token(Token = "0x6009FB7")]
			[Address(RVA = "0x31B2440", Offset = "0x31B1040", VA = "0x1831B2440", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x0003E460 File Offset: 0x0003C660
		[Token(Token = "0x6009FB8")]
		[Address(RVA = "0x31B1D50", Offset = "0x31B0950", VA = "0x1831B1D50")]
		public int GetServerIndex(int index)
		{
			return 0;
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FB9")]
		[Address(RVA = "0x31B1B70", Offset = "0x31B0770", VA = "0x1831B1B70", Slot = "7")]
		public IDIYPreset GetPreset(int index)
		{
			return null;
		}

		// Token: 0x06009FBA RID: 40890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FBA")]
		[Address(RVA = "0x31B15C0", Offset = "0x31B01C0", VA = "0x1831B15C0")]
		private PlayerBuildingDIYSolution CreatePreset(IDIYPreset origin)
		{
			return null;
		}

		// Token: 0x06009FBB RID: 40891 RVA: 0x0003E478 File Offset: 0x0003C678
		[Token(Token = "0x6009FBB")]
		[Address(RVA = "0x31B20D0", Offset = "0x31B0CD0", VA = "0x1831B20D0", Slot = "4")]
		public bool SetPreset(int index, IDIYPreset preset, string imageBase64, Action<ExaminResponse> resultHandler)
		{
			return default(bool);
		}

		// Token: 0x06009FBC RID: 40892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FBC")]
		[Address(RVA = "0x31B1DE0", Offset = "0x31B09E0", VA = "0x1831B1DE0", Slot = "5")]
		public void RenamePreset(int index, string newName, Action<ExaminResponse> resultHandler)
		{
		}

		// Token: 0x06009FBD RID: 40893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FBD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FurniturePresetManager()
		{
		}

		// Token: 0x020018B0 RID: 6320
		[Token(Token = "0x20018B0")]
		private class Preset : IDIYPreset
		{
			// Token: 0x17001229 RID: 4649
			// (get) Token: 0x06009FBE RID: 40894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001229")]
			public string name
			{
				[Token(Token = "0x6009FBE")]
				[Address(RVA = "0x31B9C40", Offset = "0x31B8840", VA = "0x1831B9C40", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700122A RID: 4650
			// (get) Token: 0x06009FBF RID: 40895 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700122A")]
			public string roomType
			{
				[Token(Token = "0x6009FBF")]
				[Address(RVA = "0x31B9C90", Offset = "0x31B8890", VA = "0x1831B9C90", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700122B RID: 4651
			// (get) Token: 0x06009FC0 RID: 40896 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700122B")]
			public string floorModifierId
			{
				[Token(Token = "0x6009FC0")]
				[Address(RVA = "0x31B9B50", Offset = "0x31B8750", VA = "0x1831B9B50", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700122C RID: 4652
			// (get) Token: 0x06009FC1 RID: 40897 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700122C")]
			public string wallModifierId
			{
				[Token(Token = "0x6009FC1")]
				[Address(RVA = "0x31B9D40", Offset = "0x31B8940", VA = "0x1831B9D40", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700122D RID: 4653
			// (get) Token: 0x06009FC2 RID: 40898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700122D")]
			public string thumbnailUrl
			{
				[Token(Token = "0x6009FC2")]
				[Address(RVA = "0x31B9CE0", Offset = "0x31B88E0", VA = "0x1831B9CE0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700122E RID: 4654
			// (get) Token: 0x06009FC3 RID: 40899 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700122E")]
			public IEnumerable<DIYPresetItem> items
			{
				[Token(Token = "0x6009FC3")]
				[Address(RVA = "0x31B9BC0", Offset = "0x31B87C0", VA = "0x1831B9BC0", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06009FC4 RID: 40900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009FC4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Preset()
			{
			}

			// Token: 0x0400963A RID: 38458
			[Token(Token = "0x400963A")]
			[FieldOffset(Offset = "0x10")]
			public PlayerBuildingDIYPreset buildingPreset;
		}
	}
}
