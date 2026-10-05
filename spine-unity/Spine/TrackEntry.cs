using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class TrackEntry : Pool<TrackEntry>.IPoolable
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000EB RID: 235 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000EC RID: 236 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000007")]
		public event AnimationState.TrackEntryDelegate Start
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x4E4A940", Offset = "0x4E49540", VA = "0x184E4A940")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x4E4AE10", Offset = "0x4E49A10", VA = "0x184E4AE10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000ED RID: 237 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000EE RID: 238 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000008")]
		public event AnimationState.TrackEntryDelegate Interrupt
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x4E4A8A0", Offset = "0x4E494A0", VA = "0x184E4A8A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x4E4AD70", Offset = "0x4E49970", VA = "0x184E4AD70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000EF RID: 239 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000F0 RID: 240 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000009")]
		public event AnimationState.TrackEntryDelegate End
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x4E4A760", Offset = "0x4E49360", VA = "0x184E4A760")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x4E4AC30", Offset = "0x4E49830", VA = "0x184E4AC30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000F1 RID: 241 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000F2 RID: 242 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400000A")]
		public event AnimationState.TrackEntryDelegate Dispose
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x4E4A6C0", Offset = "0x4E492C0", VA = "0x184E4A6C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x4E4AB90", Offset = "0x4E49790", VA = "0x184E4AB90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000F3 RID: 243 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000F4 RID: 244 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400000B")]
		public event AnimationState.TrackEntryDelegate Complete
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x4E4A620", Offset = "0x4E49220", VA = "0x184E4A620")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x4E4AAF0", Offset = "0x4E496F0", VA = "0x184E4AAF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060000F5 RID: 245 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060000F6 RID: 246 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400000C")]
		public event AnimationState.TrackEntryEventDelegate Event
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x4E4A800", Offset = "0x4E49400", VA = "0x184E4A800")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x4E4ACD0", Offset = "0x4E498D0", VA = "0x184E4ACD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x31E2D10", Offset = "0x31E1910", VA = "0x1831E2D10")]
		internal void OnStart()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x4E4A2F0", Offset = "0x4E48EF0", VA = "0x184E4A2F0")]
		internal void OnInterrupt()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x4E4A2B0", Offset = "0x4E48EB0", VA = "0x184E4A2B0")]
		internal void OnEnd()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x3153EA0", Offset = "0x3152AA0", VA = "0x183153EA0")]
		internal void OnDispose()
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4E4A290", Offset = "0x4E48E90", VA = "0x184E4A290")]
		internal void OnComplete()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4E4A2D0", Offset = "0x4E48ED0", VA = "0x184E4A2D0")]
		internal void OnEvent(Event e)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4E4A360", Offset = "0x4E48F60", VA = "0x184E4A360", Slot = "4")]
		public void Reset()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x1700003E")]
		public int TrackIndex
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700003F")]
		public Animation Animation
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000254C File Offset: 0x0000074C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000040")]
		public bool Loop
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x4E18D40", Offset = "0x4E17940", VA = "0x184E18D40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x4E4AEE0", Offset = "0x4E49AE0", VA = "0x184E4AEE0")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000041")]
		public float Delay
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x45C1800", Offset = "0x45C0400", VA = "0x1845C1800")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x45C1860", Offset = "0x45C0460", VA = "0x1845C1860")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000042")]
		public float TrackTime
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x144F800", Offset = "0x144E400", VA = "0x18144F800")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x4E4AF10", Offset = "0x4E49B10", VA = "0x184E4AF10")]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002594 File Offset: 0x00000794
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000043")]
		public float TrackEnd
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x4E4AAE0", Offset = "0x4E496E0", VA = "0x184E4AAE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x4E4AF00", Offset = "0x4E49B00", VA = "0x184E4AF00")]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000025AC File Offset: 0x000007AC
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000044")]
		public float AnimationStart
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1692750", Offset = "0x1691350", VA = "0x181692750")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1692B80", Offset = "0x1691780", VA = "0x181692B80")]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000045")]
		public float AnimationEnd
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1EC7FD0", Offset = "0x1EC6BD0", VA = "0x181EC7FD0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x4E48A70", Offset = "0x4E47670", VA = "0x184E48A70")]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000025DC File Offset: 0x000007DC
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000046")]
		public float AnimationLast
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1692770", Offset = "0x1691370", VA = "0x181692770")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x4E4AEC0", Offset = "0x4E49AC0", VA = "0x184E4AEC0")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x17000047")]
		public float NextAnimationLast
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1692760", Offset = "0x1691360", VA = "0x181692760")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x17000048")]
		public float AnimationTime
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x4E4A9E0", Offset = "0x4E495E0", VA = "0x184E4A9E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000049")]
		public float TimeScale
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x4E4AAD0", Offset = "0x4E496D0", VA = "0x184E4AAD0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x4E4AEF0", Offset = "0x4E49AF0", VA = "0x184E4AEF0")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004A")]
		public float Alpha
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x14488A0", Offset = "0x14474A0", VA = "0x1814488A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x4E4AEB0", Offset = "0x4E49AB0", VA = "0x184E4AEB0")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002654 File Offset: 0x00000854
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004B")]
		public float EventThreshold
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1692630", Offset = "0x1691230", VA = "0x181692630")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1692B20", Offset = "0x1691720", VA = "0x181692B20")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004C")]
		public float AttachmentThreshold
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x4E40370", Offset = "0x4E3EF70", VA = "0x184E40370")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x4E407D0", Offset = "0x4E3F3D0", VA = "0x184E407D0")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002684 File Offset: 0x00000884
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004D")]
		public float DrawOrderThreshold
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x157CF40", Offset = "0x157BB40", VA = "0x18157CF40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x157D080", Offset = "0x157BC80", VA = "0x18157D080")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700004E")]
		public TrackEntry Next
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x1700004F")]
		public bool IsComplete
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x4E4AAB0", Offset = "0x4E496B0", VA = "0x184E4AAB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000050")]
		public float MixTime
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x4E48970", Offset = "0x4E47570", VA = "0x184E48970")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x4E48AA0", Offset = "0x4E476A0", VA = "0x184E48AA0")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000026CC File Offset: 0x000008CC
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000051")]
		public float MixDuration
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x4E48990", Offset = "0x4E47590", VA = "0x184E48990")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x4E48AC0", Offset = "0x4E476C0", VA = "0x184E48AC0")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000026E4 File Offset: 0x000008E4
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000052")]
		public MixBlend MixBlend
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x7893A0", Offset = "0x787FA0", VA = "0x1807893A0")]
			get
			{
				return MixBlend.Setup;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x789460", Offset = "0x788060", VA = "0x180789460")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000053")]
		public TrackEntry MixingFrom
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000054")]
		public TrackEntry MixingTo
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000026FC File Offset: 0x000008FC
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000055")]
		public bool HoldPrevious
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x4E18CE0", Offset = "0x4E178E0", VA = "0x184E18CE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x4E4AED0", Offset = "0x4E49AD0", VA = "0x184E4AED0")]
			set
			{
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4E4A310", Offset = "0x4E48F10", VA = "0x184E4A310")]
		public void ResetRotationDirections()
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x4E4A490", Offset = "0x4E49090", VA = "0x184E4A490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4E4A4E0", Offset = "0x4E490E0", VA = "0x184E4A4E0")]
		public TrackEntry()
		{
		}

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x10")]
		internal Animation animation;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x18")]
		internal TrackEntry next;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x20")]
		internal TrackEntry mixingFrom;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x28")]
		internal TrackEntry mixingTo;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x60")]
		internal int trackIndex;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x64")]
		internal bool loop;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x65")]
		internal bool holdPrevious;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x68")]
		internal float eventThreshold;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x6C")]
		internal float attachmentThreshold;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x70")]
		internal float drawOrderThreshold;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x74")]
		internal float animationStart;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x78")]
		internal float animationEnd;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x7C")]
		internal float animationLast;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x80")]
		internal float nextAnimationLast;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x84")]
		internal float delay;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x88")]
		internal float trackTime;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x8C")]
		internal float trackLast;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x90")]
		internal float nextTrackLast;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x94")]
		internal float trackEnd;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x98")]
		internal float timeScale;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x9C")]
		internal float alpha;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0xA0")]
		internal float mixTime;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0xA4")]
		internal float mixDuration;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0xA8")]
		internal float interruptAlpha;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0xAC")]
		internal float totalAlpha;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0xB0")]
		internal MixBlend mixBlend;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0xB8")]
		internal readonly ExposedList<int> timelineMode;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly ExposedList<TrackEntry> timelineHoldMix;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly ExposedList<float> timelinesRotation;
	}
}
