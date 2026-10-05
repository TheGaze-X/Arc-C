using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	public sealed class ListDrawerSettingsAttribute : Attribute
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public bool ShowPaging
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4E18D40", Offset = "0x4E17940", VA = "0x184E18D40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x4E18DC0", Offset = "0x4E179C0", VA = "0x184E18DC0")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public bool DraggableItems
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x4E18CE0", Offset = "0x4E178E0", VA = "0x184E18CE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x4E18D60", Offset = "0x4E17960", VA = "0x184E18D60")]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public int NumberOfItemsPerPage
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x4E18D90", Offset = "0x4E17990", VA = "0x184E18D90")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x4E18D00", Offset = "0x4E17900", VA = "0x184E18D00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x4E18D80", Offset = "0x4E17980", VA = "0x184E18D80")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public bool ShowItemCount
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x4E18D30", Offset = "0x4E17930", VA = "0x184E18D30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x4E18DB0", Offset = "0x4E179B0", VA = "0x184E18DB0")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		[Obsolete("Use ShowFoldout instead, which is what Expanded has always done. If you want to control the default expanded state, use DefaultExpandedState. Expanded has been implemented wrong for a long time.")]
		public bool Expanded
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x4E18CF0", Offset = "0x4E178F0", VA = "0x184E18CF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x4E18D70", Offset = "0x4E17970", VA = "0x184E18D70")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public bool DefaultExpandedState
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2109C30", Offset = "0x2108830", VA = "0x182109C30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x4E18D50", Offset = "0x4E17950", VA = "0x184E18D50")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public bool ShowIndexLabels
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1692610", Offset = "0x1691210", VA = "0x181692610")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x4E18DA0", Offset = "0x4E179A0", VA = "0x184E18DA0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public string OnTitleBarGUI
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x1700002C")]
		public bool PagingHasValue
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x1700002D")]
		public bool ShowItemCountHasValue
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x4E18D20", Offset = "0x4E17920", VA = "0x184E18D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x1700002E")]
		public bool NumberOfItemsPerPageHasValue
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1692600", Offset = "0x1691200", VA = "0x181692600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x1700002F")]
		public bool DraggableHasValue
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xE31BA0", Offset = "0xE307A0", VA = "0x180E31BA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000030")]
		public bool IsReadOnlyHasValue
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE31BC0", Offset = "0xE307C0", VA = "0x180E31BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000031")]
		public bool ShowIndexLabelsHasValue
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x4E18D10", Offset = "0x4E17910", VA = "0x184E18D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x17000032")]
		public bool DefaultExpandedStateHasValue
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x4E18CD0", Offset = "0x4E178D0", VA = "0x184E18CD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4E18CC0", Offset = "0x4E178C0", VA = "0x184E18CC0")]
		public ListDrawerSettingsAttribute()
		{
		}

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x10")]
		public bool HideAddButton;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x11")]
		public bool HideRemoveButton;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x18")]
		public string ListElementLabelName;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x20")]
		public string CustomAddFunction;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x28")]
		public string CustomRemoveIndexFunction;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x30")]
		public string CustomRemoveElementFunction;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x38")]
		public string OnBeginListElementGUI;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x40")]
		public string OnEndListElementGUI;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x48")]
		public bool AlwaysAddDefaultValue;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x49")]
		public bool AddCopiesLastElement;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x50")]
		public string ElementColor;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x58")]
		private string onTitleBarGUI;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x60")]
		private int numberOfItemsPerPage;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x64")]
		private bool paging;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x65")]
		private bool draggable;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x66")]
		private bool isReadOnly;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x67")]
		private bool showItemCount;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x68")]
		private bool pagingHasValue;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x69")]
		private bool draggableHasValue;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x6A")]
		private bool isReadOnlyHasValue;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x6B")]
		private bool showItemCountHasValue;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x6C")]
		private bool numberOfItemsPerPageHasValue;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x6D")]
		private bool showIndexLabels;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x6E")]
		private bool showIndexLabelsHasValue;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x6F")]
		private bool defaultExpandedStateHasValue;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x70")]
		private bool defaultExpandedState;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x71")]
		public bool ShowFoldout;
	}
}
