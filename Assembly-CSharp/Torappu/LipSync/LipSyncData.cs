using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.LipSync
{
	// Token: 0x02001462 RID: 5218
	[Token(Token = "0x2001462")]
	[Serializable]
	public class LipSyncData
	{
		// Token: 0x060078CF RID: 30927 RVA: 0x00036618 File Offset: 0x00034818
		[Token(Token = "0x60078CF")]
		[Address(RVA = "0x2638FF0", Offset = "0x2637BF0", VA = "0x182638FF0")]
		public bool Import(string path)
		{
			return default(bool);
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078D0")]
		[Address(RVA = "0x26393A0", Offset = "0x2637FA0", VA = "0x1826393A0")]
		public LipSyncData()
		{
		}

		// Token: 0x040076C8 RID: 30408
		[Token(Token = "0x40076C8")]
		[FieldOffset(Offset = "0x10")]
		public string actionName;

		// Token: 0x040076C9 RID: 30409
		[Token(Token = "0x40076C9")]
		[FieldOffset(Offset = "0x18")]
		public List<LipSyncData.SpineAnimationInfo> animationInfos;

		// Token: 0x040076CA RID: 30410
		[Token(Token = "0x40076CA")]
		[FieldOffset(Offset = "0x20")]
		public List<LipSyncData.EventInfo> eventInfos;

		// Token: 0x040076CB RID: 30411
		[Token(Token = "0x40076CB")]
		[FieldOffset(Offset = "0x28")]
		public BakedData bakedData;

		// Token: 0x02001463 RID: 5219
		[Token(Token = "0x2001463")]
		[Serializable]
		public class SpineAnimationInfo
		{
			// Token: 0x060078D1 RID: 30929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpineAnimationInfo()
			{
			}

			// Token: 0x040076CC RID: 30412
			[Token(Token = "0x40076CC")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x040076CD RID: 30413
			[Token(Token = "0x40076CD")]
			[FieldOffset(Offset = "0x18")]
			public double time;

			// Token: 0x040076CE RID: 30414
			[Token(Token = "0x40076CE")]
			[FieldOffset(Offset = "0x20")]
			public double blendInDuration;
		}

		// Token: 0x02001464 RID: 5220
		[Token(Token = "0x2001464")]
		[Serializable]
		public class EventInfo
		{
			// Token: 0x060078D2 RID: 30930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EventInfo()
			{
			}

			// Token: 0x040076CF RID: 30415
			[Token(Token = "0x40076CF")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x040076D0 RID: 30416
			[Token(Token = "0x40076D0")]
			[FieldOffset(Offset = "0x18")]
			public double time;
		}

		// Token: 0x02001465 RID: 5221
		[Token(Token = "0x2001465")]
		[Serializable]
		public class ai
		{
			// Token: 0x060078D3 RID: 30931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ai()
			{
			}

			// Token: 0x040076D1 RID: 30417
			[Token(Token = "0x40076D1")]
			[FieldOffset(Offset = "0x10")]
			public string n;

			// Token: 0x040076D2 RID: 30418
			[Token(Token = "0x40076D2")]
			[FieldOffset(Offset = "0x18")]
			public double t;

			// Token: 0x040076D3 RID: 30419
			[Token(Token = "0x40076D3")]
			[FieldOffset(Offset = "0x20")]
			public double i;
		}

		// Token: 0x02001466 RID: 5222
		[Token(Token = "0x2001466")]
		[Serializable]
		public class ei
		{
			// Token: 0x060078D4 RID: 30932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ei()
			{
			}

			// Token: 0x040076D4 RID: 30420
			[Token(Token = "0x40076D4")]
			[FieldOffset(Offset = "0x10")]
			public string n;

			// Token: 0x040076D5 RID: 30421
			[Token(Token = "0x40076D5")]
			[FieldOffset(Offset = "0x18")]
			public double t;
		}

		// Token: 0x02001467 RID: 5223
		[Token(Token = "0x2001467")]
		[Serializable]
		public class lsi
		{
			// Token: 0x060078D5 RID: 30933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D5")]
			[Address(RVA = "0x264E680", Offset = "0x264D280", VA = "0x18264E680")]
			public lsi()
			{
			}

			// Token: 0x040076D6 RID: 30422
			[Token(Token = "0x40076D6")]
			[FieldOffset(Offset = "0x10")]
			public string an;

			// Token: 0x040076D7 RID: 30423
			[Token(Token = "0x40076D7")]
			[FieldOffset(Offset = "0x18")]
			public List<LipSyncData.ai> ais;

			// Token: 0x040076D8 RID: 30424
			[Token(Token = "0x40076D8")]
			[FieldOffset(Offset = "0x20")]
			public List<LipSyncData.ei> eis;
		}
	}
}
