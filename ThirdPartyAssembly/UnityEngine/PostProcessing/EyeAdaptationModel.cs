using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[Serializable]
	public class EyeAdaptationModel : PostProcessingModel
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600038F RID: 911 RVA: 0x000034C8 File Offset: 0x000016C8
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000069")]
		public EyeAdaptationModel.Settings settings
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x54230F0", Offset = "0x5421CF0", VA = "0x1854230F0")]
			get
			{
				return default(EyeAdaptationModel.Settings);
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x5423120", Offset = "0x5421D20", VA = "0x185423120")]
			set
			{
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x5422FF0", Offset = "0x5421BF0", VA = "0x185422FF0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x5423070", Offset = "0x5421C70", VA = "0x185423070")]
		public EyeAdaptationModel()
		{
		}

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EyeAdaptationModel.Settings m_Settings;

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		public enum EyeAdaptationType
		{
			// Token: 0x040004CD RID: 1229
			[Token(Token = "0x40004CD")]
			Progressive,
			// Token: 0x040004CE RID: 1230
			[Token(Token = "0x40004CE")]
			Fixed
		}

		// Token: 0x020000D1 RID: 209
		[Token(Token = "0x20000D1")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000393 RID: 915 RVA: 0x000034E0 File Offset: 0x000016E0
			[Token(Token = "0x1700006A")]
			public static EyeAdaptationModel.Settings defaultSettings
			{
				[Token(Token = "0x6000393")]
				[Address(RVA = "0x54321C0", Offset = "0x5430DC0", VA = "0x1854321C0")]
				get
				{
					return default(EyeAdaptationModel.Settings);
				}
			}

			// Token: 0x040004CF RID: 1231
			[Token(Token = "0x40004CF")]
			[FieldOffset(Offset = "0x0")]
			[Range(1f, 99f)]
			[Tooltip("Filters the dark part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
			public float lowPercent;

			// Token: 0x040004D0 RID: 1232
			[Token(Token = "0x40004D0")]
			[FieldOffset(Offset = "0x4")]
			[Range(1f, 99f)]
			[Tooltip("Filters the bright part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
			public float highPercent;

			// Token: 0x040004D1 RID: 1233
			[Token(Token = "0x40004D1")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Minimum average luminance to consider for auto exposure (in EV).")]
			public float minLuminance;

			// Token: 0x040004D2 RID: 1234
			[Token(Token = "0x40004D2")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Maximum average luminance to consider for auto exposure (in EV).")]
			public float maxLuminance;

			// Token: 0x040004D3 RID: 1235
			[Token(Token = "0x40004D3")]
			[FieldOffset(Offset = "0x10")]
			[PPMin(0f)]
			[Tooltip("Exposure bias. Use this to control the global exposure of the scene.")]
			public float keyValue;

			// Token: 0x040004D4 RID: 1236
			[Token(Token = "0x40004D4")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Set this to true to let Unity handle the key value automatically based on average luminance.")]
			public bool dynamicKeyValue;

			// Token: 0x040004D5 RID: 1237
			[Token(Token = "0x40004D5")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Use \"Progressive\" if you want the auto exposure to be animated. Use \"Fixed\" otherwise.")]
			public EyeAdaptationModel.EyeAdaptationType adaptationType;

			// Token: 0x040004D6 RID: 1238
			[Token(Token = "0x40004D6")]
			[FieldOffset(Offset = "0x1C")]
			[PPMin(0f)]
			[Tooltip("Adaptation speed from a dark to a light environment.")]
			public float speedUp;

			// Token: 0x040004D7 RID: 1239
			[Token(Token = "0x40004D7")]
			[FieldOffset(Offset = "0x20")]
			[PPMin(0f)]
			[Tooltip("Adaptation speed from a light to a dark environment.")]
			public float speedDown;

			// Token: 0x040004D8 RID: 1240
			[Token(Token = "0x40004D8")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("Lower bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
			[Range(-16f, -1f)]
			public int logMin;

			// Token: 0x040004D9 RID: 1241
			[Token(Token = "0x40004D9")]
			[FieldOffset(Offset = "0x28")]
			[Range(1f, 16f)]
			[Tooltip("Upper bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
			public int logMax;
		}
	}
}
