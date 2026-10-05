using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[Serializable]
	public class FontData : ISerializationCallbackReceiver
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public static FontData defaultFontData
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x5A126C0", Offset = "0x5A112C0", VA = "0x185A126C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000029")]
		public Font font
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002A")]
		public int fontSize
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002B")]
		public FontStyle fontStyle
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return FontStyle.Normal;
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002C")]
		public bool bestFit
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002D")]
		public int minSize
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002E")]
		public int maxSize
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002F")]
		public TextAnchor alignment
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return TextAnchor.UpperLeft;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000030")]
		public bool alignByGeometry
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000031")]
		public bool richText
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x4E1BBB0", Offset = "0x4E1A7B0", VA = "0x184E1BBB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x508CBF0", Offset = "0x508B7F0", VA = "0x18508CBF0")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000032")]
		public HorizontalWrapMode horizontalOverflow
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return HorizontalWrapMode.Wrap;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x4A83F60", Offset = "0x4A82B60", VA = "0x184A83F60")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000033")]
		public VerticalWrapMode verticalOverflow
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return VerticalWrapMode.Truncate;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000034")]
		public float lineSpacing
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CDA20", VA = "0x1807CEE20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1692880", Offset = "0x1691480", VA = "0x181692880")]
			set
			{
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x5A12670", Offset = "0x5A11270", VA = "0x185A12670", Slot = "5")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FontData()
		{
		}

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("font")]
		[SerializeField]
		private Font m_Font;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("fontSize")]
		private int m_FontSize;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[FormerlySerializedAs("fontStyle")]
		private FontStyle m_FontStyle;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_BestFit;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_MinSize;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_MaxSize;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("alignment")]
		[SerializeField]
		private TextAnchor m_Alignment;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_AlignByGeometry;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		[FormerlySerializedAs("richText")]
		private bool m_RichText;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private HorizontalWrapMode m_HorizontalOverflow;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VerticalWrapMode m_VerticalOverflow;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_LineSpacing;
	}
}
