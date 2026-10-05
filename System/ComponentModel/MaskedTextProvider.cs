using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	public class MaskedTextProvider : ICloneable
	{
		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x5150F40", Offset = "0x514FB40", VA = "0x185150F40")]
		public MaskedTextProvider(string mask)
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x5150E90", Offset = "0x514FA90", VA = "0x185150E90")]
		public MaskedTextProvider(string mask, bool restrictToAscii)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x5150990", Offset = "0x514F590", VA = "0x185150990")]
		public MaskedTextProvider(string mask, CultureInfo culture)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x51509C0", Offset = "0x514F5C0", VA = "0x1851509C0")]
		public MaskedTextProvider(string mask, CultureInfo culture, bool restrictToAscii)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x5150ED0", Offset = "0x514FAD0", VA = "0x185150ED0")]
		public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x5150F00", Offset = "0x514FB00", VA = "0x185150F00")]
		public MaskedTextProvider(string mask, CultureInfo culture, char passwordChar, bool allowPromptAsInput)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x51509F0", Offset = "0x514F5F0", VA = "0x1851509F0")]
		public MaskedTextProvider(string mask, CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii)
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x514CA70", Offset = "0x514B670", VA = "0x18514CA70")]
		private void Initialize()
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x17000261")]
		public bool AllowPromptAsInput
		{
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x5150F70", Offset = "0x514FB70", VA = "0x185150F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000262")]
		public int AssignedEditPositionCount
		{
			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x17000263")]
		public int AvailableEditPositionCount
		{
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x5151030", Offset = "0x514FC30", VA = "0x185151030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x514B910", Offset = "0x514A510", VA = "0x18514B910", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000264")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x17000265")]
		public static char DefaultPasswordChar
		{
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x5000AD0", Offset = "0x4FFF6D0", VA = "0x185000AD0")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x17000266")]
		public int EditPositionCount
		{
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x5151040", Offset = "0x514FC40", VA = "0x185151040")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000267")]
		public IEnumerator EditPositions
		{
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x5151050", Offset = "0x514FC50", VA = "0x185151050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00006660 File Offset: 0x00004860
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000268")]
		public bool IncludeLiterals
		{
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x5151230", Offset = "0x514FE30", VA = "0x185151230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x51515A0", Offset = "0x51501A0", VA = "0x1851515A0")]
			set
			{
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00006678 File Offset: 0x00004878
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000269")]
		public bool IncludePrompt
		{
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x5151290", Offset = "0x514FE90", VA = "0x185151290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x5151610", Offset = "0x5150210", VA = "0x185151610")]
			set
			{
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x1700026A")]
		public bool AsciiOnly
		{
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x5150FD0", Offset = "0x514FBD0", VA = "0x185150FD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000066A8 File Offset: 0x000048A8
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700026B")]
		public bool IsPassword
		{
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x51512F0", Offset = "0x514FEF0", VA = "0x1851512F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x5151680", Offset = "0x5150280", VA = "0x185151680")]
			set
			{
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x1700026C")]
		public static int InvalidIndex
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x1700026D")]
		public int LastAssignedPosition
		{
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x51513D0", Offset = "0x514FFD0", VA = "0x1851513D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x1700026E")]
		public int Length
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x5151420", Offset = "0x5150020", VA = "0x185151420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026F")]
		public string Mask
		{
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x17000270")]
		public bool MaskCompleted
		{
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x5151440", Offset = "0x5150040", VA = "0x185151440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x17000271")]
		public bool MaskFull
		{
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x5151450", Offset = "0x5150050", VA = "0x185151450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00006738 File Offset: 0x00004938
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000272")]
		public char PasswordChar
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x5151460", Offset = "0x5150060", VA = "0x185151460")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x5151700", Offset = "0x5150300", VA = "0x185151700")]
			set
			{
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00006750 File Offset: 0x00004950
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000273")]
		public char PromptChar
		{
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x5151470", Offset = "0x5150070", VA = "0x185151470")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x5151850", Offset = "0x5150450", VA = "0x185151850")]
			set
			{
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00006768 File Offset: 0x00004968
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000274")]
		public bool ResetOnPrompt
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x5151480", Offset = "0x5150080", VA = "0x185151480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x5151A10", Offset = "0x5150610", VA = "0x185151A10")]
			set
			{
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00006780 File Offset: 0x00004980
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000275")]
		public bool ResetOnSpace
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x51514E0", Offset = "0x51500E0", VA = "0x1851514E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x5151A80", Offset = "0x5150680", VA = "0x185151A80")]
			set
			{
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00006798 File Offset: 0x00004998
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000276")]
		public bool SkipLiterals
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x5151540", Offset = "0x5150140", VA = "0x185151540")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x5151AF0", Offset = "0x51506F0", VA = "0x185151AF0")]
			set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		[Token(Token = "0x17000277")]
		public char this[int index]
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x5151300", Offset = "0x514FF00", VA = "0x185151300")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x514B6F0", Offset = "0x514A2F0", VA = "0x18514B6F0")]
		public bool Add(char input)
		{
			return default(bool);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x514B5B0", Offset = "0x514A1B0", VA = "0x18514B5B0")]
		public bool Add(char input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x514B480", Offset = "0x514A080", VA = "0x18514B480")]
		public bool Add(string input)
		{
			return default(bool);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x514B350", Offset = "0x5149F50", VA = "0x18514B350")]
		public bool Add(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x514B8F0", Offset = "0x514A4F0", VA = "0x18514B8F0")]
		public void Clear()
		{
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x514B7F0", Offset = "0x514A3F0", VA = "0x18514B7F0")]
		public void Clear(out MaskedTextResultHint resultHint)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x514C380", Offset = "0x514AF80", VA = "0x18514C380")]
		public int FindAssignedEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x514C400", Offset = "0x514B000", VA = "0x18514C400")]
		public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x514C500", Offset = "0x514B100", VA = "0x18514C500")]
		public int FindEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x514C570", Offset = "0x514B170", VA = "0x18514C570")]
		public int FindEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x514C590", Offset = "0x514B190", VA = "0x18514C590")]
		private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, byte assignedStatus)
		{
			return 0;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x514C6C0", Offset = "0x514B2C0", VA = "0x18514C6C0")]
		public int FindNonEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x514C730", Offset = "0x514B330", VA = "0x18514C730")]
		public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x514C750", Offset = "0x514B350", VA = "0x18514C750")]
		private int FindPositionInRange(int startPosition, int endPosition, bool direction, MaskedTextProvider.CharType charTypeFlags)
		{
			return 0;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x514C840", Offset = "0x514B440", VA = "0x18514C840")]
		public int FindUnassignedEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x514C960", Offset = "0x514B560", VA = "0x18514C960")]
		public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x514CA60", Offset = "0x514B660", VA = "0x18514CA60")]
		public static bool GetOperationResultFromHint(MaskedTextResultHint hint)
		{
			return default(bool);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x514D320", Offset = "0x514BF20", VA = "0x18514D320")]
		public bool InsertAt(char input, int position)
		{
			return default(bool);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x514D470", Offset = "0x514C070", VA = "0x18514D470")]
		public bool InsertAt(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x514D690", Offset = "0x514C290", VA = "0x18514D690")]
		public bool InsertAt(string input, int position)
		{
			return default(bool);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x514D5A0", Offset = "0x514C1A0", VA = "0x18514D5A0")]
		public bool InsertAt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x514CF30", Offset = "0x514BB30", VA = "0x18514CF30")]
		private bool InsertAtInt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			return default(bool);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x514D830", Offset = "0x514C430", VA = "0x18514D830")]
		private static bool IsAscii(char c)
		{
			return default(bool);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x514D780", Offset = "0x514C380", VA = "0x18514D780")]
		private static bool IsAciiAlphanumeric(char c)
		{
			return default(bool);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x514D7B0", Offset = "0x514C3B0", VA = "0x18514D7B0")]
		private static bool IsAlphanumeric(char c)
		{
			return default(bool);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x4C809D0", Offset = "0x4C7F5D0", VA = "0x184C809D0")]
		private static bool IsAsciiLetter(char c)
		{
			return default(bool);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x514D850", Offset = "0x514C450", VA = "0x18514D850")]
		public bool IsAvailablePosition(int position)
		{
			return default(bool);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x514D940", Offset = "0x514C540", VA = "0x18514D940")]
		public bool IsEditPosition(int position)
		{
			return default(bool);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x514D910", Offset = "0x514C510", VA = "0x18514D910")]
		private static bool IsEditPosition(MaskedTextProvider.CharDescriptor charDescriptor)
		{
			return default(bool);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x514DA00", Offset = "0x514C600", VA = "0x18514DA00")]
		private static bool IsLiteralPosition(MaskedTextProvider.CharDescriptor charDescriptor)
		{
			return default(bool);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00006A68 File Offset: 0x00004C68
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x514DA30", Offset = "0x514C630", VA = "0x18514DA30")]
		private static bool IsPrintableChar(char c)
		{
			return default(bool);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x514DAE0", Offset = "0x514C6E0", VA = "0x18514DAE0")]
		public static bool IsValidInputChar(char c)
		{
			return default(bool);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00006A98 File Offset: 0x00004C98
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x514DB30", Offset = "0x514C730", VA = "0x18514DB30")]
		public static bool IsValidMaskChar(char c)
		{
			return default(bool);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x514DB80", Offset = "0x514C780", VA = "0x18514DB80")]
		public static bool IsValidPasswordChar(char c)
		{
			return default(bool);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x514E200", Offset = "0x514CE00", VA = "0x18514E200")]
		public bool Remove()
		{
			return default(bool);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x514E160", Offset = "0x514CD60", VA = "0x18514E160")]
		public bool Remove(out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x514E040", Offset = "0x514CC40", VA = "0x18514E040")]
		public bool RemoveAt(int position)
		{
			return default(bool);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x514E0C0", Offset = "0x514CCC0", VA = "0x18514E0C0")]
		public bool RemoveAt(int startPosition, int endPosition)
		{
			return default(bool);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x514DFA0", Offset = "0x514CBA0", VA = "0x18514DFA0")]
		public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x514DBE0", Offset = "0x514C7E0", VA = "0x18514DBE0")]
		private bool RemoveAtInt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			return default(bool);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x514E810", Offset = "0x514D410", VA = "0x18514E810")]
		public bool Replace(char input, int position)
		{
			return default(bool);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x514E600", Offset = "0x514D200", VA = "0x18514E600")]
		public bool Replace(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x514E9F0", Offset = "0x514D5F0", VA = "0x18514E9F0")]
		public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x514E710", Offset = "0x514D310", VA = "0x18514E710")]
		public bool Replace(string input, int position)
		{
			return default(bool);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x514E8F0", Offset = "0x514D4F0", VA = "0x18514E8F0")]
		public bool Replace(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x514E260", Offset = "0x514CE60", VA = "0x18514E260")]
		public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x514EB20", Offset = "0x514D720", VA = "0x18514EB20")]
		private void ResetChar(int testPosition)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x514EBD0", Offset = "0x514D7D0", VA = "0x18514EBD0")]
		private void ResetString(int startPosition, int endPosition)
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x514F100", Offset = "0x514DD00", VA = "0x18514F100")]
		public bool Set(string input)
		{
			return default(bool);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x514F270", Offset = "0x514DE70", VA = "0x18514F270")]
		public bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x514EF70", Offset = "0x514DB70", VA = "0x18514EF70")]
		private void SetChar(char input, int position)
		{
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x514EDD0", Offset = "0x514D9D0", VA = "0x18514EDD0")]
		private void SetChar(char input, int position, MaskedTextProvider.CharDescriptor charDescriptor)
		{
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x514EFF0", Offset = "0x514DBF0", VA = "0x18514EFF0")]
		private void SetString(string input, int testPosition)
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x514F3B0", Offset = "0x514DFB0", VA = "0x18514F3B0")]
		private bool TestChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00006C30 File Offset: 0x00004E30
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x514FA20", Offset = "0x514E620", VA = "0x18514FA20")]
		private bool TestEscapeChar(char input, int position)
		{
			return default(bool);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00006C48 File Offset: 0x00004E48
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x514F860", Offset = "0x514E460", VA = "0x18514F860")]
		private bool TestEscapeChar(char input, int position, MaskedTextProvider.CharDescriptor charDex)
		{
			return default(bool);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00006C60 File Offset: 0x00004E60
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x514FAA0", Offset = "0x514E6A0", VA = "0x18514FAA0")]
		private bool TestSetChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00006C78 File Offset: 0x00004E78
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x514FB10", Offset = "0x514E710", VA = "0x18514FB10")]
		private bool TestSetString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x514FB80", Offset = "0x514E780", VA = "0x18514FB80")]
		private bool TestString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x514FCE0", Offset = "0x514E8E0", VA = "0x18514FCE0")]
		public string ToDisplayString()
		{
			return null;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x5150510", Offset = "0x514F110", VA = "0x185150510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x514FED0", Offset = "0x514EAD0", VA = "0x18514FED0")]
		public string ToString(bool ignorePasswordChar)
		{
			return null;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x514FFE0", Offset = "0x514EBE0", VA = "0x18514FFE0")]
		public string ToString(int startPosition, int length)
		{
			return null;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x5150400", Offset = "0x514F000", VA = "0x185150400")]
		public string ToString(bool ignorePasswordChar, int startPosition, int length)
		{
			return null;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x5150620", Offset = "0x514F220", VA = "0x185150620")]
		public string ToString(bool includePrompt, bool includeLiterals)
		{
			return null;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x514FEA0", Offset = "0x514EAA0", VA = "0x18514FEA0")]
		public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			return null;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x51500F0", Offset = "0x514ECF0", VA = "0x1851500F0")]
		public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			return null;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x5150680", Offset = "0x514F280", VA = "0x185150680")]
		public bool VerifyChar(char input, int position, out MaskedTextResultHint hint)
		{
			return default(bool);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x5150700", Offset = "0x514F300", VA = "0x185150700")]
		public bool VerifyEscapeChar(char input, int position)
		{
			return default(bool);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x51507B0", Offset = "0x514F3B0", VA = "0x1851507B0")]
		public bool VerifyString(string input)
		{
			return default(bool);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x5150770", Offset = "0x514F370", VA = "0x185150770")]
		public bool VerifyString(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return default(bool);
		}

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		private const char SPACE_CHAR = ' ';

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		private const char DEFAULT_PROMPT_CHAR = '_';

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		private const char NULL_PASSWORD_CHAR = '\0';

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		private const bool DEFAULT_ALLOW_PROMPT = true;

		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x40006EA")]
		private const int INVALID_INDEX = -1;

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		private const byte EDIT_ANY = 0;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		private const byte EDIT_UNASSIGNED = 1;

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		private const byte EDIT_ASSIGNED = 2;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		private const bool FORWARD = true;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		private const bool BACKWARD = false;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x0")]
		private static int s_ASCII_ONLY;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x4")]
		private static int s_ALLOW_PROMPT_AS_INPUT;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x8")]
		private static int s_INCLUDE_PROMPT;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0xC")]
		private static int s_INCLUDE_LITERALS;

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x10")]
		private static int s_RESET_ON_PROMPT;

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x14")]
		private static int s_RESET_ON_LITERALS;

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x18")]
		private static int s_SKIP_SPACE;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x20")]
		private static Type s_maskTextProviderType;

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x10")]
		private BitVector32 _flagState;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x18")]
		private StringBuilder _testString;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x20")]
		private int _requiredCharCount;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x24")]
		private int _requiredEditChars;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x28")]
		private int _optionalEditChars;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x2C")]
		private char _passwordChar;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x2E")]
		private char _promptChar;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x30")]
		private List<MaskedTextProvider.CharDescriptor> _stringDescriptor;

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		private enum CaseConversion
		{
			// Token: 0x04000704 RID: 1796
			[Token(Token = "0x4000704")]
			None,
			// Token: 0x04000705 RID: 1797
			[Token(Token = "0x4000705")]
			ToLower,
			// Token: 0x04000706 RID: 1798
			[Token(Token = "0x4000706")]
			ToUpper
		}

		// Token: 0x020001CB RID: 459
		[Token(Token = "0x20001CB")]
		[Flags]
		private enum CharType
		{
			// Token: 0x04000708 RID: 1800
			[Token(Token = "0x4000708")]
			EditOptional = 1,
			// Token: 0x04000709 RID: 1801
			[Token(Token = "0x4000709")]
			EditRequired = 2,
			// Token: 0x0400070A RID: 1802
			[Token(Token = "0x400070A")]
			Separator = 4,
			// Token: 0x0400070B RID: 1803
			[Token(Token = "0x400070B")]
			Literal = 8,
			// Token: 0x0400070C RID: 1804
			[Token(Token = "0x400070C")]
			Modifier = 16
		}

		// Token: 0x020001CC RID: 460
		[Token(Token = "0x20001CC")]
		private class CharDescriptor
		{
			// Token: 0x06000C17 RID: 3095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x513AF60", Offset = "0x5139B60", VA = "0x18513AF60")]
			public CharDescriptor(int maskPos, MaskedTextProvider.CharType charType)
			{
			}

			// Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x513AD00", Offset = "0x5139900", VA = "0x18513AD00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400070D RID: 1805
			[Token(Token = "0x400070D")]
			[FieldOffset(Offset = "0x10")]
			public int MaskPosition;

			// Token: 0x0400070E RID: 1806
			[Token(Token = "0x400070E")]
			[FieldOffset(Offset = "0x14")]
			public MaskedTextProvider.CaseConversion CaseConversion;

			// Token: 0x0400070F RID: 1807
			[Token(Token = "0x400070F")]
			[FieldOffset(Offset = "0x18")]
			public MaskedTextProvider.CharType CharType;

			// Token: 0x04000710 RID: 1808
			[Token(Token = "0x4000710")]
			[FieldOffset(Offset = "0x1C")]
			public bool IsAssigned;
		}
	}
}
