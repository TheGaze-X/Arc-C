using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Yoga
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[DefaultMember("Item")]
	internal class YogaNode : IEnumerable<YogaNode>, IEnumerable
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5B4FD40", Offset = "0x5B4E940", VA = "0x185B4FD40")]
		public YogaNode([Optional] YogaConfig config)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5B4F5C0", Offset = "0x5B4E1C0", VA = "0x185B4F5C0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000004 RID: 4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		internal YogaConfig Config
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x5B50690", Offset = "0x5B4F290", VA = "0x185B50690")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x17000005")]
		public bool IsDirty
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x5B4FF20", Offset = "0x5B4EB20", VA = "0x185B4FF20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x5B4F840", Offset = "0x5B4E440", VA = "0x185B4F840", Slot = "6")]
		public virtual void MarkDirty()
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x17000006")]
		public bool HasNewLayout
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x5B4FED0", Offset = "0x5B4EAD0", VA = "0x185B4FED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x17000007")]
		public bool IsMeasureDefined
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x5B4FF60", Offset = "0x5B4EB60", VA = "0x185B4FF60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x17000008")]
		public bool IsBaselineDefined
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x5B4FF10", Offset = "0x5B4EB10", VA = "0x185B4FF10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x5B4F570", Offset = "0x5B4E170", VA = "0x185B4F570")]
		public void CopyStyle(YogaNode srcNode)
		{
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000009")]
		public YogaFlexDirection FlexDirection
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x5B50860", Offset = "0x5B4F460", VA = "0x185B50860")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public YogaJustify JustifyContent
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x5B50A50", Offset = "0x5B4F650", VA = "0x185B50A50")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		public YogaDisplay Display
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x5B50760", Offset = "0x5B4F360", VA = "0x185B50760")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000C")]
		public YogaAlign AlignItems
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x5B50440", Offset = "0x5B4F040", VA = "0x185B50440")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000D")]
		public YogaAlign AlignSelf
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x5B50490", Offset = "0x5B4F090", VA = "0x185B50490")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000E")]
		public YogaAlign AlignContent
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x5B503F0", Offset = "0x5B4EFF0", VA = "0x185B503F0")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		public YogaPositionType PositionType
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x5B50F80", Offset = "0x5B4FB80", VA = "0x185B50F80")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public YogaWrap Wrap
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x5B51160", Offset = "0x5B4FD60", VA = "0x185B51160")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000011")]
		public float Flex
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x5B50950", Offset = "0x5B4F550", VA = "0x185B50950")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000012")]
		public float FlexGrow
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x5B508B0", Offset = "0x5B4F4B0", VA = "0x185B508B0")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000013")]
		public float FlexShrink
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x5B50900", Offset = "0x5B4F500", VA = "0x185B50900")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		public YogaValue FlexBasis
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x5B507B0", Offset = "0x5B4F3B0", VA = "0x185B507B0")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000015")]
		public YogaValue Width
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x5B510B0", Offset = "0x5B4FCB0", VA = "0x185B510B0")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public YogaValue Height
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x5B509A0", Offset = "0x5B4F5A0", VA = "0x185B509A0")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000017")]
		public YogaValue MaxWidth
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x5B50BE0", Offset = "0x5B4F7E0", VA = "0x185B50BE0")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000018")]
		public YogaValue MaxHeight
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x5B50B60", Offset = "0x5B4F760", VA = "0x185B50B60")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000019")]
		public YogaValue MinWidth
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x5B50CE0", Offset = "0x5B4F8E0", VA = "0x185B50CE0")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public YogaValue MinHeight
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x5B50C60", Offset = "0x5B4F860", VA = "0x185B50C60")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x1700001B")]
		public float LayoutX
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x5B50370", Offset = "0x5B4EF70", VA = "0x185B50370")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x1700001C")]
		public float LayoutY
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x5B503B0", Offset = "0x5B4EFB0", VA = "0x185B503B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x1700001D")]
		public float LayoutRight
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x5B502F0", Offset = "0x5B4EEF0", VA = "0x185B502F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002158 File Offset: 0x00000358
		[Token(Token = "0x1700001E")]
		public float LayoutBottom
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x5B50070", Offset = "0x5B4EC70", VA = "0x185B50070")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002170 File Offset: 0x00000370
		[Token(Token = "0x1700001F")]
		public float LayoutWidth
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x5B50330", Offset = "0x5B4EF30", VA = "0x185B50330")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002188 File Offset: 0x00000388
		[Token(Token = "0x17000020")]
		public float LayoutHeight
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x5B500B0", Offset = "0x5B4ECB0", VA = "0x185B500B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000021 RID: 33
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000021")]
		public YogaOverflow Overflow
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x5B50D60", Offset = "0x5B4F960", VA = "0x185B50D60")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000021A0 File Offset: 0x000003A0
		[Token(Token = "0x17000022")]
		public int Count
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x5B4FE90", Offset = "0x5B4EA90", VA = "0x185B4FE90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x5B4F880", Offset = "0x5B4E480", VA = "0x185B4F880")]
		public void MarkLayoutSeen()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x5B4F6F0", Offset = "0x5B4E2F0", VA = "0x185B4F6F0")]
		public void Insert(int index, YogaNode node)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5B4F960", Offset = "0x5B4E560", VA = "0x185B4F960")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x5B4F440", Offset = "0x5B4E040", VA = "0x185B4F440")]
		public void Clear()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x5B4FA30", Offset = "0x5B4E630", VA = "0x185B4FA30")]
		public void SetMeasureFunction(MeasureFunction measureFunction)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x5B4F3B0", Offset = "0x5B4DFB0", VA = "0x185B4F3B0")]
		public void CalculateLayout(float width = float.NaN, float height = float.NaN)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000021B8 File Offset: 0x000003B8
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x5B4F8C0", Offset = "0x5B4E4C0", VA = "0x185B4F8C0")]
		public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			return default(YogaSize);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000021D0 File Offset: 0x000003D0
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x5B4F320", Offset = "0x5B4DF20", VA = "0x185B4F320")]
		public static float BaselineInternal(YogaNode node, float width, float height)
		{
			return 0f;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x5B4F680", Offset = "0x5B4E280", VA = "0x185B4F680", Slot = "4")]
		public IEnumerator<YogaNode> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5B4FCD0", Offset = "0x5B4E8D0", VA = "0x185B4FCD0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000023 RID: 35
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000023")]
		public YogaValue Left
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x5B50AA0", Offset = "0x5B4F6A0", VA = "0x185B50AA0")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public YogaValue Top
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x5B51040", Offset = "0x5B4FC40", VA = "0x185B51040")]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000025")]
		public YogaValue Right
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x5B50FD0", Offset = "0x5B4FBD0", VA = "0x185B50FD0")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000026")]
		public YogaValue Bottom
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x5B50620", Offset = "0x5B4F220", VA = "0x185B50620")]
			set
			{
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5B4FC50", Offset = "0x5B4E850", VA = "0x185B4FC50")]
		private void SetStylePosition(YogaEdge edge, YogaValue value)
		{
		}

		// Token: 0x17000027 RID: 39
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000027")]
		public YogaValue MarginLeft
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x5B50B30", Offset = "0x5B4F730", VA = "0x185B50B30")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000028")]
		public YogaValue MarginTop
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x5B50B50", Offset = "0x5B4F750", VA = "0x185B50B50")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000029")]
		public YogaValue MarginRight
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x5B50B40", Offset = "0x5B4F740", VA = "0x185B50B40")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002A")]
		public YogaValue MarginBottom
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x5B50B20", Offset = "0x5B4F720", VA = "0x185B50B20")]
			set
			{
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x5B4FB20", Offset = "0x5B4E720", VA = "0x185B4FB20")]
		private void SetStyleMargin(YogaEdge edge, YogaValue value)
		{
		}

		// Token: 0x1700002B RID: 43
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002B")]
		public YogaValue PaddingLeft
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x5B50E20", Offset = "0x5B4FA20", VA = "0x185B50E20")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002C")]
		public YogaValue PaddingTop
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x5B50F10", Offset = "0x5B4FB10", VA = "0x185B50F10")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002D")]
		public YogaValue PaddingRight
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x5B50EA0", Offset = "0x5B4FAA0", VA = "0x185B50EA0")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public YogaValue PaddingBottom
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x5B50DB0", Offset = "0x5B4F9B0", VA = "0x185B50DB0")]
			set
			{
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x5B4FBD0", Offset = "0x5B4E7D0", VA = "0x185B4FBD0")]
		private void SetStylePadding(YogaEdge edge, YogaValue value)
		{
		}

		// Token: 0x1700002F RID: 47
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002F")]
		public float BorderLeftWidth
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x5B50530", Offset = "0x5B4F130", VA = "0x185B50530")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000030")]
		public float BorderTopWidth
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x5B505D0", Offset = "0x5B4F1D0", VA = "0x185B505D0")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000031")]
		public float BorderRightWidth
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x5B50580", Offset = "0x5B4F180", VA = "0x185B50580")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000032")]
		public float BorderBottomWidth
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x5B504E0", Offset = "0x5B4F0E0", VA = "0x185B504E0")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x17000033")]
		public float LayoutMarginLeft
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x5B50130", Offset = "0x5B4ED30", VA = "0x185B50130")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x17000034")]
		public float LayoutMarginTop
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x5B501B0", Offset = "0x5B4EDB0", VA = "0x185B501B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x17000035")]
		public float LayoutMarginRight
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x5B50170", Offset = "0x5B4ED70", VA = "0x185B50170")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x17000036")]
		public float LayoutMarginBottom
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x5B500F0", Offset = "0x5B4ECF0", VA = "0x185B500F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x17000037")]
		public float LayoutPaddingLeft
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x5B50230", Offset = "0x5B4EE30", VA = "0x185B50230")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x17000038")]
		public float LayoutPaddingTop
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x5B502B0", Offset = "0x5B4EEB0", VA = "0x185B502B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x17000039")]
		public float LayoutPaddingRight
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x5B50270", Offset = "0x5B4EE70", VA = "0x185B50270")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x1700003A")]
		public float LayoutPaddingBottom
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x5B501F0", Offset = "0x5B4EDF0", VA = "0x185B501F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x1700003B")]
		public float LayoutBorderLeft
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x5B4FFB0", Offset = "0x5B4EBB0", VA = "0x185B4FFB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x1700003C")]
		public float LayoutBorderTop
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x5B50030", Offset = "0x5B4EC30", VA = "0x185B50030")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x1700003D")]
		public float LayoutBorderRight
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x5B4FFF0", Offset = "0x5B4EBF0", VA = "0x185B4FFF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x1700003E")]
		public float LayoutBorderBottom
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x5B4FF70", Offset = "0x5B4EB70", VA = "0x185B4FF70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr _ygNode;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private YogaConfig _config;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WeakReference _parent;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<YogaNode> _children;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeasureFunction _measureFunction;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BaselineFunction _baselineFunction;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _data;
	}
}
