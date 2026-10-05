using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013F9 RID: 5113
	[Token(Token = "0x20013F9")]
	public struct CharacterTrackPointData
	{
		// Token: 0x060074E9 RID: 29929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E9")]
		[Address(RVA = "0x2303E40", Offset = "0x2302A40", VA = "0x182303E40")]
		public void LoadData(string charId)
		{
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x060074EA RID: 29930 RVA: 0x00034080 File Offset: 0x00032280
		[Token(Token = "0x17000E47")]
		public bool hasTrackPoint
		{
			[Token(Token = "0x60074EA")]
			[Address(RVA = "0x2304340", Offset = "0x2302F40", VA = "0x182304340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x00034098 File Offset: 0x00032298
		[Token(Token = "0x17000E48")]
		public bool hasTrackPointOnCard
		{
			[Token(Token = "0x60074EB")]
			[Address(RVA = "0x2304320", Offset = "0x2302F20", VA = "0x182304320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x060074EC RID: 29932 RVA: 0x000340B0 File Offset: 0x000322B0
		[Token(Token = "0x17000E49")]
		public bool hasNewVoiceTagOnCard
		{
			[Token(Token = "0x60074EC")]
			[Address(RVA = "0x2304300", Offset = "0x2302F00", VA = "0x182304300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400720B RID: 29195
		[Token(Token = "0x400720B")]
		[FieldOffset(Offset = "0x0")]
		public bool hasPotentialImprovable;

		// Token: 0x0400720C RID: 29196
		[Token(Token = "0x400720C")]
		[FieldOffset(Offset = "0x1")]
		public bool hasNewCharTag;

		// Token: 0x0400720D RID: 29197
		[Token(Token = "0x400720D")]
		[FieldOffset(Offset = "0x2")]
		public bool hasInfoTrackPoint;

		// Token: 0x0400720E RID: 29198
		[Token(Token = "0x400720E")]
		[FieldOffset(Offset = "0x3")]
		public bool hasSpCharMissionTrackPoint;

		// Token: 0x0400720F RID: 29199
		[Token(Token = "0x400720F")]
		[FieldOffset(Offset = "0x4")]
		public bool hasNewUniEquipSystem;

		// Token: 0x04007210 RID: 29200
		[Token(Token = "0x4007210")]
		[FieldOffset(Offset = "0x5")]
		public bool hasNewVoiceTag;

		// Token: 0x04007211 RID: 29201
		[Token(Token = "0x4007211")]
		[FieldOffset(Offset = "0x0")]
		public static CharacterTrackPointData DEFAULT_DATA;
	}
}
