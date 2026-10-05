using System;
using System.ComponentModel;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002882 RID: 10370
	[Token(Token = "0x2002882")]
	[Serializable]
	public struct ParamValueAtom : IEquatable<ParamValueAtom>
	{
		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06011441 RID: 70721 RVA: 0x0006A638 File Offset: 0x00068838
		// (set) Token: 0x06011442 RID: 70722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002625")]
		[JsonIgnore]
		public int valueInt
		{
			[Token(Token = "0x6011441")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6011442")]
			[Address(RVA = "0x925690", Offset = "0x924290", VA = "0x180925690")]
			set
			{
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x06011443 RID: 70723 RVA: 0x0006A650 File Offset: 0x00068850
		// (set) Token: 0x06011444 RID: 70724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002626")]
		[JsonIgnore]
		public float valueFloat
		{
			[Token(Token = "0x6011443")]
			[Address(RVA = "0x925540", Offset = "0x924140", VA = "0x180925540")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6011444")]
			[Address(RVA = "0x925670", Offset = "0x924270", VA = "0x180925670")]
			set
			{
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x06011445 RID: 70725 RVA: 0x0006A668 File Offset: 0x00068868
		// (set) Token: 0x06011446 RID: 70726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002627")]
		[JsonIgnore]
		public ulong valueULong
		{
			[Token(Token = "0x6011445")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6011446")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
			set
			{
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06011447 RID: 70727 RVA: 0x0006A680 File Offset: 0x00068880
		// (set) Token: 0x06011448 RID: 70728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002628")]
		[JsonIgnore]
		public bool valueBool
		{
			[Token(Token = "0x6011447")]
			[Address(RVA = "0x925530", Offset = "0x924130", VA = "0x180925530")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011448")]
			[Address(RVA = "0x925660", Offset = "0x924260", VA = "0x180925660")]
			set
			{
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x06011449 RID: 70729 RVA: 0x0006A698 File Offset: 0x00068898
		// (set) Token: 0x0601144A RID: 70730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002629")]
		[JsonIgnore]
		public long valueInt64
		{
			[Token(Token = "0x6011449")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x601144A")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
			set
			{
			}
		}

		// Token: 0x0601144B RID: 70731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601144B")]
		[Address(RVA = "0x925510", Offset = "0x924110", VA = "0x180925510")]
		public ParamValueAtom(bool value)
		{
		}

		// Token: 0x0601144C RID: 70732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601144C")]
		[Address(RVA = "0x925490", Offset = "0x924090", VA = "0x180925490")]
		public ParamValueAtom(int value)
		{
		}

		// Token: 0x0601144D RID: 70733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601144D")]
		[Address(RVA = "0x9254D0", Offset = "0x9240D0", VA = "0x1809254D0")]
		public ParamValueAtom(float value)
		{
		}

		// Token: 0x0601144E RID: 70734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601144E")]
		[Address(RVA = "0x9254B0", Offset = "0x9240B0", VA = "0x1809254B0")]
		public ParamValueAtom(string value)
		{
		}

		// Token: 0x0601144F RID: 70735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601144F")]
		[Address(RVA = "0x9254F0", Offset = "0x9240F0", VA = "0x1809254F0")]
		public ParamValueAtom(long value)
		{
		}

		// Token: 0x06011450 RID: 70736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011450")]
		[Address(RVA = "0x9252C0", Offset = "0x923EC0", VA = "0x1809252C0")]
		public void Clear()
		{
		}

		// Token: 0x06011451 RID: 70737 RVA: 0x0006A6B0 File Offset: 0x000688B0
		[Token(Token = "0x6011451")]
		[Address(RVA = "0x9252E0", Offset = "0x923EE0", VA = "0x1809252E0", Slot = "4")]
		public bool Equals(ParamValueAtom other)
		{
			return default(bool);
		}

		// Token: 0x06011452 RID: 70738 RVA: 0x0006A6C8 File Offset: 0x000688C8
		[Token(Token = "0x6011452")]
		[Address(RVA = "0x925350", Offset = "0x923F50", VA = "0x180925350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06011453 RID: 70739 RVA: 0x0006A6E0 File Offset: 0x000688E0
		[Token(Token = "0x6011453")]
		[Address(RVA = "0x925420", Offset = "0x924020", VA = "0x180925420", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06011454 RID: 70740 RVA: 0x0006A6F8 File Offset: 0x000688F8
		[Token(Token = "0x6011454")]
		[Address(RVA = "0x925560", Offset = "0x924160", VA = "0x180925560")]
		public static bool operator ==(ParamValueAtom left, ParamValueAtom right)
		{
			return default(bool);
		}

		// Token: 0x06011455 RID: 70741 RVA: 0x0006A710 File Offset: 0x00068910
		[Token(Token = "0x6011455")]
		[Address(RVA = "0x9255E0", Offset = "0x9241E0", VA = "0x1809255E0")]
		public static bool operator !=(ParamValueAtom left, ParamValueAtom right)
		{
			return default(bool);
		}

		// Token: 0x040134CF RID: 79055
		[Token(Token = "0x40134CF")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty(DefaultValueHandling = 3)]
		[DefaultValue(0L)]
		public long valueBit64;

		// Token: 0x040134D0 RID: 79056
		[Token(Token = "0x40134D0")]
		[FieldOffset(Offset = "0x8")]
		[JsonProperty(DefaultValueHandling = 3)]
		[DefaultValue(null)]
		public string valueString;
	}
}
