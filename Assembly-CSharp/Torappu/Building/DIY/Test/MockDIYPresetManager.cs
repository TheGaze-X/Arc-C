using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001902 RID: 6402
	[Token(Token = "0x2001902")]
	public class MockDIYPresetManager : MonoBehaviour, IDIYPresetManager, IDIYPresetProvider
	{
		// Token: 0x0600A153 RID: 41299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A153")]
		[Address(RVA = "0x31CBD60", Offset = "0x31CA960", VA = "0x1831CBD60")]
		public void Setup()
		{
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x0600A154 RID: 41300 RVA: 0x0003ED78 File Offset: 0x0003CF78
		[Token(Token = "0x17001284")]
		public int slotCount
		{
			[Token(Token = "0x600A154")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A155")]
		[Address(RVA = "0x31CBC10", Offset = "0x31CA810", VA = "0x1831CBC10", Slot = "7")]
		public IDIYPreset GetPreset(int index)
		{
			return null;
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x0003ED90 File Offset: 0x0003CF90
		[Token(Token = "0x600A156")]
		[Address(RVA = "0x31CBCA0", Offset = "0x31CA8A0", VA = "0x1831CBCA0", Slot = "4")]
		public bool SetPreset(int index, IDIYPreset preset, string imageBase64, [Optional] Action<ExaminResponse> resultHandler)
		{
			return default(bool);
		}

		// Token: 0x0600A157 RID: 41303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A157")]
		[Address(RVA = "0x31CBC60", Offset = "0x31CA860", VA = "0x1831CBC60", Slot = "5")]
		public void RenamePreset(int index, string newName, Action<ExaminResponse> resultHandler)
		{
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A158")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MockDIYPresetManager()
		{
		}

		// Token: 0x04009799 RID: 38809
		[Token(Token = "0x4009799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockDIYPresetManager.Preset[] _presets;

		// Token: 0x0400979A RID: 38810
		[Token(Token = "0x400979A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _slotCount;

		// Token: 0x0400979B RID: 38811
		[Token(Token = "0x400979B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IDIYPreset[] m_presetItems;

		// Token: 0x02001903 RID: 6403
		[Token(Token = "0x2001903")]
		[Serializable]
		public class PresetItem
		{
			// Token: 0x0600A159 RID: 41305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A159")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PresetItem()
			{
			}

			// Token: 0x0400979C RID: 38812
			[Token(Token = "0x400979C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0400979D RID: 38813
			[Token(Token = "0x400979D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int pos0;

			// Token: 0x0400979E RID: 38814
			[Token(Token = "0x400979E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int pos1;

			// Token: 0x0400979F RID: 38815
			[Token(Token = "0x400979F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int dir;
		}

		// Token: 0x02001904 RID: 6404
		[Token(Token = "0x2001904")]
		[Serializable]
		public class Preset : IDIYPreset
		{
			// Token: 0x17001285 RID: 4741
			// (get) Token: 0x0600A15A RID: 41306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001285")]
			public string name
			{
				[Token(Token = "0x600A15A")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001286 RID: 4742
			// (get) Token: 0x0600A15B RID: 41307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001286")]
			public string roomType
			{
				[Token(Token = "0x600A15B")]
				[Address(RVA = "0x31D21B0", Offset = "0x31D0DB0", VA = "0x1831D21B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001287 RID: 4743
			// (get) Token: 0x0600A15C RID: 41308 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001287")]
			public Sprite bgSprite
			{
				[Token(Token = "0x600A15C")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001288 RID: 4744
			// (get) Token: 0x0600A15D RID: 41309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001288")]
			public string floorModifierId
			{
				[Token(Token = "0x600A15D")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001289 RID: 4745
			// (get) Token: 0x0600A15E RID: 41310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001289")]
			public string wallModifierId
			{
				[Token(Token = "0x600A15E")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700128A RID: 4746
			// (get) Token: 0x0600A15F RID: 41311 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700128A")]
			public string thumbnailUrl
			{
				[Token(Token = "0x600A15F")]
				[Address(RVA = "0x31D21F0", Offset = "0x31D0DF0", VA = "0x1831D21F0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700128B RID: 4747
			// (get) Token: 0x0600A160 RID: 41312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700128B")]
			public IEnumerable<DIYPresetItem> items
			{
				[Token(Token = "0x600A160")]
				[Address(RVA = "0x31D2030", Offset = "0x31D0C30", VA = "0x1831D2030", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600A161 RID: 41313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A161")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Preset()
			{
			}

			// Token: 0x040097A0 RID: 38816
			[Token(Token = "0x40097A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string _name;

			// Token: 0x040097A1 RID: 38817
			[Token(Token = "0x40097A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Sprite _bgSprite;

			// Token: 0x040097A2 RID: 38818
			[Token(Token = "0x40097A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MockDIYPresetManager.PresetItem[] _items;

			// Token: 0x040097A3 RID: 38819
			[Token(Token = "0x40097A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string _floorModifierId;

			// Token: 0x040097A4 RID: 38820
			[Token(Token = "0x40097A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string _wallModifierId;

			// Token: 0x040097A5 RID: 38821
			[Token(Token = "0x40097A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private DIYPresetItem[] m_diyPresets;
		}
	}
}
