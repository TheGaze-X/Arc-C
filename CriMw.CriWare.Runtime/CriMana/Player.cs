using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using CriWare.CriMana.Detail;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare.CriMana
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public class Player : CriDisposable
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000046C4 File Offset: 0x000028C4
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BB")]
		private Player.Status requiredStatus
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return Player.Status.Stop;
			}
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x371A3D0", Offset = "0x3718FD0", VA = "0x18371A3D0")]
			set
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060008B8 RID: 2232 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060008B9 RID: 2233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400001B")]
		public event Player.SubtitleChangeCallback OnSubtitleChanged
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x371A100", Offset = "0x3718D00", VA = "0x18371A100")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x371A310", Offset = "0x3718F10", VA = "0x18371A310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x000046DC File Offset: 0x000028DC
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BC")]
		public bool additiveMode
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x32FC480", Offset = "0x32FB080", VA = "0x1832FC480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x32FC4D0", Offset = "0x32FB0D0", VA = "0x1832FC4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000046F4 File Offset: 0x000028F4
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BD")]
		public int maxFrameDrop
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x32FC490", Offset = "0x32FB090", VA = "0x1832FC490")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x32FC4F0", Offset = "0x32FB0F0", VA = "0x1832FC4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0000470C File Offset: 0x0000290C
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BE")]
		public bool applyTargetAlpha
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x371A3B0", Offset = "0x3718FB0", VA = "0x18371A3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00004724 File Offset: 0x00002924
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BF")]
		public bool uiRenderMode
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x371A300", Offset = "0x3718F00", VA = "0x18371A300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x371A420", Offset = "0x3719020", VA = "0x18371A420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x170000C0")]
		public bool isFrameAvailable
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x2218060", Offset = "0x2216C60", VA = "0x182218060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000C1")]
		public MovieInfo movieInfo
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x371A240", Offset = "0x3718E40", VA = "0x18371A240")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000C2")]
		public FrameInfo frameInfo
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x371A220", Offset = "0x3718E20", VA = "0x18371A220")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x170000C3")]
		public Player.Status status
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x371A270", Offset = "0x3718E70", VA = "0x18371A270")]
			get
			{
				return Player.Status.Stop;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x170000C4")]
		public Player.Status nativeStatus
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return Player.Status.Stop;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x170000C5")]
		public int numberOfEntries
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x371A250", Offset = "0x3718E50", VA = "0x18371A250")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0000479C File Offset: 0x0000299C
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C6")]
		public IntPtr subtitleBuffer
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x371A400", Offset = "0x3719000", VA = "0x18371A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x000047B4 File Offset: 0x000029B4
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C7")]
		public int subtitleSize
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x371A2E0", Offset = "0x3718EE0", VA = "0x18371A2E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x371A410", Offset = "0x3719010", VA = "0x18371A410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000C8")]
		public CriAtomExPlayer atomExPlayer
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000C9")]
		public CriAtomExPlayer subAtomExPlayer
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000CA")]
		public CriAtomExPlayer extraAtomExPlayer
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000CB")]
		public CriAtomEx3dSource atomEx3DsourceForAmbisonics
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x170000CC")]
		public Player.TimerType timerType
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x371A2F0", Offset = "0x3718EF0", VA = "0x18371A2F0")]
			get
			{
				return Player.TimerType.None;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CD")]
		public CriManaMoviePlayerHolder playerHolder
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x371A260", Offset = "0x3718E60", VA = "0x18371A260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x371A3C0", Offset = "0x3718FC0", VA = "0x18371A3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x3719F60", Offset = "0x3718B60", VA = "0x183719F60")]
		public Player()
		{
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x3719BF0", Offset = "0x37187F0", VA = "0x183719BF0")]
		public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x3713AF0", Offset = "0x37126F0", VA = "0x183713AF0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x3713A90", Offset = "0x3712690", VA = "0x183713A90", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x3713380", Offset = "0x3711F80", VA = "0x183713380")]
		public void CreateRendererResource(int width, int height, bool alpha)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x3713650", Offset = "0x3712250", VA = "0x183713650")]
		public void DisposeRendererResource()
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x3718820", Offset = "0x3717420", VA = "0x183718820")]
		public void Prepare()
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x3718630", Offset = "0x3717230", VA = "0x183718630")]
		public void PrepareForRendering()
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x37190C0", Offset = "0x3717CC0", VA = "0x1837190C0")]
		public void Start()
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x3719640", Offset = "0x3718240", VA = "0x183719640")]
		public void Stop()
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x3719410", Offset = "0x3718010", VA = "0x183719410")]
		public void StopForSeek()
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x37185C0", Offset = "0x37171C0", VA = "0x1837185C0")]
		public void Pause(bool sw)
		{
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x3714200", Offset = "0x3712E00", VA = "0x183714200")]
		public bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x3718C20", Offset = "0x3717820", VA = "0x183718C20")]
		public bool SetFile(CriFsBinder binder, string moviePath, Player.SetMode setMode = Player.SetMode.New)
		{
			return default(bool);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x3718B30", Offset = "0x3717730", VA = "0x183718B30")]
		public bool SetData(IntPtr data, long dataSize, Player.SetMode setMode = Player.SetMode.New)
		{
			return default(bool);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x3718AF0", Offset = "0x37176F0", VA = "0x183718AF0")]
		[Obsolete("Use SetData(IntPtr, Int64, SetMode) instead")]
		public bool SetData(byte[] data, long datasize, Player.SetMode setMode = Player.SetMode.New)
		{
			return default(bool);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x3718A30", Offset = "0x3717630", VA = "0x183718A30")]
		public bool SetContentId(CriFsBinder binder, int contentId, Player.SetMode setMode = Player.SetMode.New)
		{
			return default(bool);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x3718BE0", Offset = "0x37177E0", VA = "0x183718BE0")]
		public bool SetFileRange(string filePath, ulong offset, long range, Player.SetMode setMode = Player.SetMode.New)
		{
			return default(bool);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x3714360", Offset = "0x3712F60", VA = "0x183714360")]
		public void Loop(bool sw)
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x37189C0", Offset = "0x37175C0", VA = "0x1837189C0")]
		public void SetAudioBaseConcatenation(bool enabled)
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x3718D50", Offset = "0x3717950", VA = "0x183718D50")]
		public void SetMasterTimerType(Player.TimerType timerType)
		{
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x3718DA0", Offset = "0x37179A0", VA = "0x183718DA0")]
		public void SetSeekPosition(int frameNumber)
		{
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x3718D90", Offset = "0x3717990", VA = "0x183718D90")]
		public void SetMovieEventSyncMode(Player.MovieEventSyncMode mode)
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x3718DB0", Offset = "0x37179B0", VA = "0x183718DB0")]
		public void SetSpeed(float speed)
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x3718D70", Offset = "0x3717970", VA = "0x183718D70")]
		public void SetMaxPictureDataSize(uint maxDataSize)
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x3718A10", Offset = "0x3717610", VA = "0x183718A10")]
		public void SetBufferingTime(float sec)
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x3718D80", Offset = "0x3717980", VA = "0x183718D80")]
		public void SetMinBufferSize(int min_buffer_size)
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x3718A00", Offset = "0x3717600", VA = "0x183718A00")]
		public void SetAudioTrack(int track)
		{
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x37189D0", Offset = "0x37175D0", VA = "0x1837189D0")]
		public void SetAudioTrack(Player.AudioTrack track)
		{
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x3718DD0", Offset = "0x37179D0", VA = "0x183718DD0")]
		public void SetSubAudioTrack(int track)
		{
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x3718DE0", Offset = "0x37179E0", VA = "0x183718DE0")]
		public void SetSubAudioTrack(Player.AudioTrack track)
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x3718B90", Offset = "0x3717790", VA = "0x183718B90")]
		public void SetExtraAudioTrack(int track)
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x3718BA0", Offset = "0x37177A0", VA = "0x183718BA0")]
		public void SetExtraAudioTrack(Player.AudioTrack track)
		{
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x3718FD0", Offset = "0x3717BD0", VA = "0x183718FD0")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x3713BE0", Offset = "0x37127E0", VA = "0x183713BE0")]
		public float GetVolume()
		{
			return 0f;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x3718E10", Offset = "0x3717A10", VA = "0x183718E10")]
		public void SetSubAudioVolume(float volume)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x3713BC0", Offset = "0x37127C0", VA = "0x183713BC0")]
		public float GetSubAudioVolume()
		{
			return 0f;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x3718BD0", Offset = "0x37177D0", VA = "0x183718BD0")]
		public void SetExtraAudioVolume(float volume)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x3713BB0", Offset = "0x37127B0", VA = "0x183713BB0")]
		public float GetExtraAudioVolume()
		{
			return 0f;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x3718A20", Offset = "0x3717620", VA = "0x183718A20")]
		public void SetBusSendLevel(string bus_name, float level)
		{
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x3718DC0", Offset = "0x37179C0", VA = "0x183718DC0")]
		public void SetSubAudioBusSendLevel(string bus_name, float volume)
		{
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x3718B80", Offset = "0x3717780", VA = "0x183718B80")]
		public void SetExtraAudioBusSendLevel(string bus_name, float volume)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x3718E20", Offset = "0x3717A20", VA = "0x183718E20")]
		public void SetSubtitleChannel(int channel)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
		public void SetShaderDispatchCallback(Player.ShaderDispatchCallback shaderDispatchCallback)
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x3713BD0", Offset = "0x37127D0", VA = "0x183713BD0")]
		public long GetTime()
		{
			return 0L;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x3713B50", Offset = "0x3712750", VA = "0x183713B50")]
		public int GetDisplayedFrameNo()
		{
			return 0;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x3713BF0", Offset = "0x37127F0", VA = "0x183713BF0")]
		public bool HasRenderedNewFrame()
		{
			return default(bool);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x37189B0", Offset = "0x37175B0", VA = "0x1837189B0")]
		public void SetAsrRackId(int asrRackId)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x3718FC0", Offset = "0x3717BC0", VA = "0x183718FC0")]
		public void SetTimeStretchQuality(float quality)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x3718B70", Offset = "0x3717770", VA = "0x183718B70")]
		public void SetDecryptionKey(ulong key)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x3719B30", Offset = "0x3718730", VA = "0x183719B30")]
		public void UpdateWithUserTime(ulong timeCount, ulong timeUnit)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x3718CC0", Offset = "0x37178C0", VA = "0x183718CC0")]
		public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x3719AB0", Offset = "0x37186B0", VA = "0x183719AB0")]
		public void UpdateWithManualTimeAdvanced()
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x3719BD0", Offset = "0x37187D0", VA = "0x183719BD0")]
		public void Update()
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x37198C0", Offset = "0x37184C0", VA = "0x1837198C0")]
		public void SyncMasterTimer()
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x37184F0", Offset = "0x37170F0", VA = "0x1837184F0")]
		public void OnWillRenderObject(CriManaMovieMaterialBase sender)
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x37198D0", Offset = "0x37184D0", VA = "0x1837198D0")]
		public bool UpdateMaterial(Material material)
		{
			return default(bool);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x3718550", Offset = "0x3717150", VA = "0x183718550")]
		public void PauseOnApplicationPause(bool sw)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x170000CE")]
		public bool isAlive
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x371A230", Offset = "0x3718E30", VA = "0x18371A230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x3714210", Offset = "0x3712E10", VA = "0x183714210")]
		public void IssuePluginEvent(Player.CriManaUnityPlayer_RenderEventAction renderEventAction)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x3713690", Offset = "0x3712290", VA = "0x183713690")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x3713C40", Offset = "0x3712840", VA = "0x183713C40")]
		private void InternalUpdate()
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x37142A0", Offset = "0x3712EA0", VA = "0x1837142A0")]
		private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy, int playerId)
		{
			return null;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x3713630", Offset = "0x3712230", VA = "0x183713630")]
		private void DisableInfos(bool keepFrameInfo = false)
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x37186C0", Offset = "0x37172C0", VA = "0x1837186C0")]
		private void PrepareNativePlayer()
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x3719950", Offset = "0x3718550", VA = "0x183719950")]
		private void UpdateNativePlayer()
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x37140E0", Offset = "0x3712CE0", VA = "0x1837140E0")]
		private void InvokePlayerStatusCheck()
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x3711010", Offset = "0x370FC10", VA = "0x183711010")]
		private void AllocateSubtitleBuffer(int size)
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x3713580", Offset = "0x3712180", VA = "0x183713580")]
		private void DeallocateSubtitleBuffer()
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x3718FE0", Offset = "0x3717BE0", VA = "0x183718FE0")]
		internal void SetupPlayerHolder()
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x3713510", Offset = "0x3712110", VA = "0x183713510")]
		[MonoPInvokeCallback(typeof(Player.CuePointCallbackFromNativeDelegate))]
		private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, [In] ref EventPoint eventPoint)
		{
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x3719810", Offset = "0x3718410", VA = "0x183719810")]
		[MonoPInvokeCallback(typeof(Player.SubtitleCallbackFromNativeDelegate))]
		private static void SubtitleCallbackFromNative(IntPtr ptr1, IntPtr ptr2)
		{
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x3715350", Offset = "0x3713F50", VA = "0x183715350")]
		internal static int NativeMethods_GetNumberOfEntry(int playerId)
		{
			return 0;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x37145C0", Offset = "0x37131C0", VA = "0x1837145C0")]
		internal static int NativeMethods_Create()
		{
			return 0;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x3714490", Offset = "0x3713090", VA = "0x183714490")]
		internal static int NativeMethods_CreateWithParameters(bool useAtomExPlayer, uint maxPathLength)
		{
			return 0;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x3714E70", Offset = "0x3713A70", VA = "0x183714E70")]
		internal static IntPtr NativeMethods_GetAtomExPlayerByTrackId(int player_id, uint track_id)
		{
			return 0;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x37180D0", Offset = "0x3716CD0", VA = "0x1837180D0")]
		internal void NativeMethods_Stop(int player_id)
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x3715C70", Offset = "0x3714870", VA = "0x183715C70")]
		internal void NativeMethods_Pause(int player_id, int sw)
		{
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x3715A40", Offset = "0x3714640", VA = "0x183715A40")]
		internal static bool NativeMethods_IsPaused(int player_id)
		{
			return default(bool);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x3716E50", Offset = "0x3715A50", VA = "0x183716E50")]
		internal static void NativeMethods_SetFile(int player_id, IntPtr binder, string path)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x3714D10", Offset = "0x3713910", VA = "0x183714D10")]
		internal static bool NativeMethods_EntryFile(int player_id, IntPtr binder, string path, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x3716640", Offset = "0x3715240", VA = "0x183716640")]
		internal static void NativeMethods_SetData(int player_id, IntPtr data, long datasize)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x3716760", Offset = "0x3715360", VA = "0x183716760")]
		internal static void NativeMethods_SetData(int player_id, byte[] data, long datasize)
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x3714A60", Offset = "0x3713660", VA = "0x183714A60")]
		internal static bool NativeMethods_EntryData(int player_id, IntPtr data, long datasize, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x3714910", Offset = "0x3713510", VA = "0x183714910")]
		internal static bool NativeMethods_EntryData(int player_id, byte[] data, long datasize, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x3716400", Offset = "0x3715000", VA = "0x183716400")]
		internal static void NativeMethods_SetContentId(int player_id, IntPtr binder, int content_id)
		{
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x37147D0", Offset = "0x37133D0", VA = "0x1837147D0")]
		internal static bool NativeMethods_EntryContentId(int player_id, IntPtr binder, int content_id, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x3716D00", Offset = "0x3715900", VA = "0x183716D00")]
		internal static void NativeMethods_SetFileRange(int player_id, string path, ulong offset, long range)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x3714BA0", Offset = "0x37137A0", VA = "0x183714BA0")]
		internal static bool NativeMethods_EntryFileRange(int player_id, string path, ulong offset, long range, bool repeat)
		{
			return default(bool);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x3715B60", Offset = "0x3714760", VA = "0x183715B60")]
		internal void NativeMethods_Loop(int player_id, int sw)
		{
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x3715F90", Offset = "0x3714B90", VA = "0x183715F90")]
		internal static void NativeMethods_SetAudioBaseConcatenation(int player_id, bool flag)
		{
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x37170A0", Offset = "0x3715CA0", VA = "0x1837170A0")]
		internal static void NativeMethods_SetMasterTimerType(int player_id, Player.TimerType timer_type)
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x37174E0", Offset = "0x37160E0", VA = "0x1837174E0")]
		internal static void NativeMethods_SetSeekPosition(int player_id, int seek_frame_no)
		{
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x37173D0", Offset = "0x3715FD0", VA = "0x1837173D0")]
		internal static void NativeMethods_SetMovieEventSyncMode(int player_id, Player.MovieEventSyncMode mode)
		{
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x37175F0", Offset = "0x37161F0", VA = "0x1837175F0")]
		internal static void NativeMethods_SetSpeed(int player_id, float speed)
		{
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x37171B0", Offset = "0x3715DB0", VA = "0x1837171B0")]
		internal static void NativeMethods_SetMaxPictureDataSize(int player_id, uint max_data_size)
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x37161B0", Offset = "0x3714DB0", VA = "0x1837161B0")]
		internal static void NativeMethods_SetBufferingTime(int player_id, float sec)
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x37172C0", Offset = "0x3715EC0", VA = "0x1837172C0")]
		internal static void NativeMethods_SetMinBufferSize(int player_id, int min_buffer_size)
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x37160A0", Offset = "0x3714CA0", VA = "0x1837160A0")]
		internal static void NativeMethods_SetAudioTrack(int player_id, int track)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x3717840", Offset = "0x3716440", VA = "0x183717840")]
		internal static void NativeMethods_SetSubAudioTrack(int player_id, int track)
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x3716AE0", Offset = "0x37156E0", VA = "0x183716AE0")]
		internal static void NativeMethods_SetExtraAudioTrack(int player_id, int track)
		{
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x3717EC0", Offset = "0x3716AC0", VA = "0x183717EC0")]
		internal static void NativeMethods_SetVolume(int player_id, float vol)
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x3715910", Offset = "0x3714510", VA = "0x183715910")]
		internal static float NativeMethods_GetVolume(int player_id)
		{
			return 0f;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x3717950", Offset = "0x3716550", VA = "0x183717950")]
		internal static void NativeMethods_SetSubAudioVolume(int player_id, float vol)
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x3715580", Offset = "0x3714180", VA = "0x183715580")]
		internal static float NativeMethods_GetSubAudioVolume(int player_id)
		{
			return 0f;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x3716BF0", Offset = "0x37157F0", VA = "0x183716BF0")]
		internal static void NativeMethods_SetExtraAudioVolume(int player_id, float vol)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x37150C0", Offset = "0x3713CC0", VA = "0x1837150C0")]
		internal static float NativeMethods_GetExtraAudioVolume(int player_id)
		{
			return 0f;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x37162C0", Offset = "0x3714EC0", VA = "0x1837162C0")]
		internal static void NativeMethods_SetBusSendLevelByName(int player_id, string bus_name, float level)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x3717700", Offset = "0x3716300", VA = "0x183717700")]
		internal static void NativeMethods_SetSubAudioBusSendLevelByName(int player_id, string bus_name, float level)
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x37169A0", Offset = "0x37155A0", VA = "0x1837169A0")]
		internal static void NativeMethods_SetExtraAudioBusSendLevelByName(int player_id, string bus_name, float level)
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x3717A60", Offset = "0x3716660", VA = "0x183717A60")]
		internal static void NativeMethods_SetSubtitleCallback(int player_id, Player.SubtitleCallbackFromNativeDelegate cbfunc)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x3717B80", Offset = "0x3716780", VA = "0x183717B80")]
		internal static void NativeMethods_SetSubtitleChannel(int player_id, int channel)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x37157F0", Offset = "0x37143F0", VA = "0x1837157F0")]
		internal static long NativeMethods_GetTime(int player_id)
		{
			return 0L;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x3714FA0", Offset = "0x3713BA0", VA = "0x183714FA0")]
		internal static int NativeMethods_GetDisplayedFrameNo(int player_id)
		{
			return 0;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x3715E80", Offset = "0x3714A80", VA = "0x183715E80")]
		internal static void NativeMethods_SetAsrRackId(int player_id, int asr_rack_id)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x3717C90", Offset = "0x3716890", VA = "0x183717C90")]
		internal static void NativeMethods_SetTimeStretchQuality(int player_id, float quality)
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x3717DA0", Offset = "0x37169A0", VA = "0x183717DA0")]
		internal static void NativeMethods_SetUserTime(int player_id, ulong user_count, ulong user_unit)
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x3716F80", Offset = "0x3715B80", VA = "0x183716F80")]
		internal static void NativeMethods_SetManualTimerUnit(int player_id, ulong timer_unit_n, ulong timer_unit_d)
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x3714390", Offset = "0x3712F90", VA = "0x183714390")]
		internal static void NativeMethods_AdvanceManualTimer(int player_id)
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x37181D0", Offset = "0x3716DD0", VA = "0x1837181D0")]
		internal static void NativeMethods_SyncMasterTimer(int player_id)
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x3715470", Offset = "0x3714070", VA = "0x183715470")]
		internal static IntPtr NativeMethods_GetRenderEventFunc()
		{
			return 0;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x37146D0", Offset = "0x37132D0", VA = "0x1837146D0")]
		internal static void NativeMethods_Destroy(int player_id)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x37182D0", Offset = "0x3716ED0", VA = "0x1837182D0")]
		internal static void NativeMethods_SyncUpdate(int player_id)
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x37151F0", Offset = "0x3713DF0", VA = "0x1837151F0")]
		internal static void NativeMethods_GetMovieInfo(int player_id, [Out] MovieInfo movie_info)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x3717FD0", Offset = "0x3716BD0", VA = "0x183717FD0")]
		internal void NativeMethods_Start(int player_id)
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x3715D80", Offset = "0x3714980", VA = "0x183715D80")]
		internal void NativeMethods_Prepare(int player_id)
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x37183D0", Offset = "0x3716FD0", VA = "0x1837183D0")]
		internal static int NativeMethods_Update(int player_id)
		{
			return 0;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x3716520", Offset = "0x3715120", VA = "0x183716520")]
		internal static void NativeMethods_SetCuePointCallback(int player_id, Player.CuePointCallbackFromNativeDelegate cbfunc)
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x37156B0", Offset = "0x37142B0", VA = "0x1837156B0")]
		internal static int NativeMethods_GetSubtitleOnTime(int player_id, IntPtr subtitle_buffer, int subtitle_buffer_size)
		{
			return 0;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x3716890", Offset = "0x3715490", VA = "0x183716890")]
		internal static void NativeMethods_SetDecryptionKey(int player_id, ulong key)
		{
		}

		// Token: 0x06000955 RID: 2389
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x3712EE0", Offset = "0x3711AE0", VA = "0x183712EE0")]
		[PreserveSig]
		internal static extern int CRIWAREE876C886();

		// Token: 0x06000956 RID: 2390
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x3712BB0", Offset = "0x37117B0", VA = "0x183712BB0")]
		[PreserveSig]
		internal static extern int CRIWAREC062D006();

		// Token: 0x06000957 RID: 2391
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x3711D60", Offset = "0x3710960", VA = "0x183711D60")]
		[PreserveSig]
		internal static extern int CRIWARE4A87DB5C(bool useAtomExPlayer, uint maxPathLength);

		// Token: 0x06000958 RID: 2392
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x3711540", Offset = "0x3710140", VA = "0x183711540")]
		[PreserveSig]
		internal static extern void CRIWARE14EB1872(int player_id);

		// Token: 0x06000959 RID: 2393
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x3712DB0", Offset = "0x37119B0", VA = "0x183712DB0")]
		[PreserveSig]
		internal static extern void CRIWAREE22B49D8(int player_id, IntPtr binder, string path);

		// Token: 0x0600095A RID: 2394
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x3711A50", Offset = "0x3710650", VA = "0x183711A50")]
		[PreserveSig]
		internal static extern void CRIWARE341F577B(int player_id, IntPtr binder, int content_id);

		// Token: 0x0600095B RID: 2395
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x3711AF0", Offset = "0x37106F0", VA = "0x183711AF0")]
		[PreserveSig]
		internal static extern void CRIWARE4036379F(int player_id, string path, ulong offset, long range);

		// Token: 0x0600095C RID: 2396
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x37111F0", Offset = "0x370FDF0", VA = "0x1837111F0")]
		[PreserveSig]
		internal static extern void CRIWARE0C529F63(int player_id, IntPtr data, long datasize);

		// Token: 0x0600095D RID: 2397
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x3711290", Offset = "0x370FE90", VA = "0x183711290")]
		[PreserveSig]
		internal static extern void CRIWARE0C529F63(int player_id, byte[] data, long datasize);

		// Token: 0x0600095E RID: 2398
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x37128C0", Offset = "0x37114C0", VA = "0x1837128C0")]
		[PreserveSig]
		internal static extern bool CRIWAREB48F72B8(int player_id, IntPtr binder, string path, bool repeat);

		// Token: 0x0600095F RID: 2399
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x3712210", Offset = "0x3710E10", VA = "0x183712210")]
		[PreserveSig]
		internal static extern bool CRIWARE7AE54FDD(int player_id, IntPtr binder, int content_id, bool repeat);

		// Token: 0x06000960 RID: 2400
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x37123D0", Offset = "0x3710FD0", VA = "0x1837123D0")]
		[PreserveSig]
		internal static extern bool CRIWARE8B9E05D1(int player_id, string path, ulong offset, long range, bool repeat);

		// Token: 0x06000961 RID: 2401
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x3711330", Offset = "0x370FF30", VA = "0x183711330")]
		[PreserveSig]
		internal static extern bool CRIWARE13AF3A46(int player_id, IntPtr data, long datasize, bool repeat);

		// Token: 0x06000962 RID: 2402
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x37113E0", Offset = "0x370FFE0", VA = "0x1837113E0")]
		[PreserveSig]
		internal static extern bool CRIWARE13AF3A46(int player_id, byte[] data, long datasize, bool repeat);

		// Token: 0x06000963 RID: 2403
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x37124A0", Offset = "0x37110A0", VA = "0x1837124A0")]
		[PreserveSig]
		internal static extern void CRIWARE8CB1B7CC(int player_id);

		// Token: 0x06000964 RID: 2404
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x3712D30", Offset = "0x3711930", VA = "0x183712D30")]
		[PreserveSig]
		internal static extern int CRIWAREDC7A9039(int player_id);

		// Token: 0x06000965 RID: 2405
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x3712F50", Offset = "0x3711B50", VA = "0x183712F50")]
		[PreserveSig]
		internal static extern void CRIWAREEADB6DEA(int player_id, Player.CuePointCallbackFromNativeDelegate cbfunc);

		// Token: 0x06000966 RID: 2406
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x37132F0", Offset = "0x3711EF0", VA = "0x1837132F0")]
		[PreserveSig]
		internal static extern void CRIWAREFEF2147B(int player_id, Player.SubtitleCallbackFromNativeDelegate cbfunc);

		// Token: 0x06000967 RID: 2407
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x37130F0", Offset = "0x3711CF0", VA = "0x1837130F0")]
		[PreserveSig]
		internal static extern void CRIWAREF77A9B06(int player_id, [Out] MovieInfo movie_info);

		// Token: 0x06000968 RID: 2408
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x37126B0", Offset = "0x37112B0", VA = "0x1837126B0")]
		[PreserveSig]
		internal static extern int CRIWARE9D6DF2A5(int player_id);

		// Token: 0x06000969 RID: 2409
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x37125A0", Offset = "0x37111A0", VA = "0x1837125A0")]
		[PreserveSig]
		internal static extern void CRIWARE959E4269(int player_id);

		// Token: 0x0600096A RID: 2410
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x3712520", Offset = "0x3711120", VA = "0x183712520")]
		[PreserveSig]
		internal static extern void CRIWARE949088C1(int player_id);

		// Token: 0x0600096B RID: 2411
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x37122C0", Offset = "0x3710EC0", VA = "0x1837122C0")]
		[PreserveSig]
		internal static extern void CRIWARE8303B4D4(int player_id);

		// Token: 0x0600096C RID: 2412
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x3711BB0", Offset = "0x37107B0", VA = "0x183711BB0")]
		[PreserveSig]
		internal static extern void CRIWARE4395A3DA(int player_id, int seek_frame_no);

		// Token: 0x0600096D RID: 2413
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x3713060", Offset = "0x3711C60", VA = "0x183713060")]
		[PreserveSig]
		internal static extern void CRIWAREF502498D(int player_id, Player.MovieEventSyncMode mode);

		// Token: 0x0600096E RID: 2414
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x3712A10", Offset = "0x3711610", VA = "0x183712A10")]
		[PreserveSig]
		internal static extern void CRIWAREB8E6C310(int player_id, int sw);

		// Token: 0x0600096F RID: 2415
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x3711780", Offset = "0x3710380", VA = "0x183711780")]
		[PreserveSig]
		internal static extern bool CRIWARE26DD65CC(int player_id);

		// Token: 0x06000970 RID: 2416
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x3712CA0", Offset = "0x37118A0", VA = "0x183712CA0")]
		[PreserveSig]
		internal static extern void CRIWAREC8B899BE(int player_id, int sw);

		// Token: 0x06000971 RID: 2417
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x3711940", Offset = "0x3710540", VA = "0x183711940")]
		[PreserveSig]
		internal static extern void CRIWARE2F11EF05(int player_id, bool flag);

		// Token: 0x06000972 RID: 2418
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x3712AA0", Offset = "0x37116A0", VA = "0x183712AA0")]
		[PreserveSig]
		internal static extern long CRIWAREBAA8F9D9(int player_id);

		// Token: 0x06000973 RID: 2419
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x3711C40", Offset = "0x3710840", VA = "0x183711C40")]
		[PreserveSig]
		internal static extern int CRIWARE44413D00(int player_id);

		// Token: 0x06000974 RID: 2420
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x3712340", Offset = "0x3710F40", VA = "0x183712340")]
		[PreserveSig]
		internal static extern IntPtr CRIWARE8B2D675B(int player_id, uint track_id);

		// Token: 0x06000975 RID: 2421
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x3712E60", Offset = "0x3711A60", VA = "0x183712E60")]
		[PreserveSig]
		internal static extern int CRIWAREE460B3D8(int player_id);

		// Token: 0x06000976 RID: 2422
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x3712030", Offset = "0x3710C30", VA = "0x183712030")]
		[PreserveSig]
		internal static extern void CRIWARE6C5FB551(int player_id, int track);

		// Token: 0x06000977 RID: 2423
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x3711F10", Offset = "0x3710B10", VA = "0x183711F10")]
		[PreserveSig]
		internal static extern void CRIWARE6026A40D(int player_id, float vol);

		// Token: 0x06000978 RID: 2424
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x3712C20", Offset = "0x3711820", VA = "0x183712C20")]
		[PreserveSig]
		internal static extern float CRIWAREC0EF06CB(int player_id);

		// Token: 0x06000979 RID: 2425
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x3711FA0", Offset = "0x3710BA0", VA = "0x183711FA0")]
		[PreserveSig]
		internal static extern void CRIWARE6B983595(int player_id, int track);

		// Token: 0x0600097A RID: 2426
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x3713260", Offset = "0x3711E60", VA = "0x183713260")]
		[PreserveSig]
		internal static extern void CRIWAREFAFCF08A(int player_id, float vol);

		// Token: 0x0600097B RID: 2427
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x3712840", Offset = "0x3711440", VA = "0x183712840")]
		[PreserveSig]
		internal static extern float CRIWAREAFAF2514(int player_id);

		// Token: 0x0600097C RID: 2428
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x37115C0", Offset = "0x37101C0", VA = "0x1837115C0")]
		[PreserveSig]
		internal static extern void CRIWARE17CEB774(int player_id, int track);

		// Token: 0x0600097D RID: 2429
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x3712B20", Offset = "0x3711720", VA = "0x183712B20")]
		[PreserveSig]
		internal static extern void CRIWAREBD501C85(int player_id, float vol);

		// Token: 0x0600097E RID: 2430
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x3712730", Offset = "0x3711330", VA = "0x183712730")]
		[PreserveSig]
		internal static extern float CRIWAREA035D305(int player_id);

		// Token: 0x0600097F RID: 2431
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x37120C0", Offset = "0x3710CC0", VA = "0x1837120C0")]
		[PreserveSig]
		internal static extern void CRIWARE7664C592(int player_id, string bus_name, float level);

		// Token: 0x06000980 RID: 2432
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x3711490", Offset = "0x3710090", VA = "0x183711490")]
		[PreserveSig]
		internal static extern void CRIWARE1473A93D(int player_id, string bus_name, float level);

		// Token: 0x06000981 RID: 2433
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x3711890", Offset = "0x3710490", VA = "0x183711890")]
		[PreserveSig]
		internal static extern void CRIWARE29FA2B02(int player_id, string bus_name, float level);

		// Token: 0x06000982 RID: 2434
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x3711800", Offset = "0x3710400", VA = "0x183711800")]
		[PreserveSig]
		internal static extern void CRIWARE275978C3(int player_id, int channel);

		// Token: 0x06000983 RID: 2435
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x3712170", Offset = "0x3710D70", VA = "0x183712170")]
		[PreserveSig]
		internal static extern int CRIWARE774161EF(int player_id, IntPtr subtitle_buffer, int subtitle_buffer_size);

		// Token: 0x06000984 RID: 2436
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x3711160", Offset = "0x370FD60", VA = "0x183711160")]
		[PreserveSig]
		internal static extern void CRIWARE06A8929C(int player_id, float speed);

		// Token: 0x06000985 RID: 2437
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x37127B0", Offset = "0x37113B0", VA = "0x1837127B0")]
		[PreserveSig]
		internal static extern void CRIWAREA16157B4(int player_id, uint max_data_size);

		// Token: 0x06000986 RID: 2438
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x3712620", Offset = "0x3711220", VA = "0x183712620")]
		[PreserveSig]
		internal static extern void CRIWARE96E92747(int player_id, float sec);

		// Token: 0x06000987 RID: 2439
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x37131D0", Offset = "0x3711DD0", VA = "0x1837131D0")]
		[PreserveSig]
		internal static extern void CRIWAREF8D6A82D(int player_id, int min_buffer_size);

		// Token: 0x06000988 RID: 2440
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x3711DF0", Offset = "0x37109F0", VA = "0x183711DF0")]
		[PreserveSig]
		internal static extern void CRIWARE5421BA66(int player_id, int asr_rack_id);

		// Token: 0x06000989 RID: 2441
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x3711650", Offset = "0x3710250", VA = "0x183711650")]
		[PreserveSig]
		internal static extern void CRIWARE19FBE70F(int player_id, float quality);

		// Token: 0x0600098A RID: 2442
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x3712FE0", Offset = "0x3711BE0", VA = "0x183712FE0")]
		[PreserveSig]
		internal static extern void CRIWAREEF5D54ED(int player_id);

		// Token: 0x0600098B RID: 2443
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x3712980", Offset = "0x3711580", VA = "0x183712980")]
		[PreserveSig]
		internal static extern void CRIWAREB71193FE(int player_id, Player.TimerType timer_type);

		// Token: 0x0600098C RID: 2444
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x3711CC0", Offset = "0x37108C0", VA = "0x183711CC0")]
		[PreserveSig]
		internal static extern void CRIWARE451BA763(int player_id, ulong user_count, ulong user_unit);

		// Token: 0x0600098D RID: 2445
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x37116E0", Offset = "0x37102E0", VA = "0x1837116E0")]
		[PreserveSig]
		internal static extern void CRIWARE22F128A3(int player_id, ulong timer_unit_n, ulong timer_unit_d);

		// Token: 0x0600098E RID: 2446
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x37119D0", Offset = "0x37105D0", VA = "0x1837119D0")]
		[PreserveSig]
		internal static extern void CRIWARE32377ABC(int player_id);

		// Token: 0x0600098F RID: 2447
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x37110E0", Offset = "0x370FCE0", VA = "0x1837110E0")]
		[PreserveSig]
		internal static extern void CRIWARE049707B0(int player_id);

		// Token: 0x06000990 RID: 2448
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x3711E80", Offset = "0x3710A80", VA = "0x183711E80")]
		[PreserveSig]
		internal static extern void CRIWARE5D3C7FCE(int player_id, ulong key);

		// Token: 0x06000991 RID: 2449
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x371A1A0", Offset = "0x3718DA0", VA = "0x18371A1A0")]
		[PreserveSig]
		internal static extern IntPtr criWareUnity_GetRenderEventFunc();

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		private const int InvalidPlayerId = -1;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Player updatingPlayer;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int playerId;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool isDisposed;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Player.Status internalrequiredStatus;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Player.Status _nativeStatus;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Player.Status? lastNativeStatus;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Player.Status? lastPlayerStatus;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool wasStopping;

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool isPreparingForRendering;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool isNativeStartInvoked;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		private bool isNativeInitialized;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RendererResource rendererResource;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MovieInfo _movieInfo;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private FrameInfo _frameInfo;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool isMovieInfoAvailable;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isFrameInfoAvailable;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Player.ShaderDispatchCallback _shaderDispatchCallback;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool enableSubtitle;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int subtitleBufferSize;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private uint droppedFrameCount;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CriAtomExPlayer _atomExPlayer;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CriAtomExPlayer _subAtomExPlayer;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private CriAtomExPlayer _extraAtomExPlayer;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CriAtomEx3dSource _atomEx3Dsource;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Player.TimerType _timerType;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool isStoppingForSeek;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Player.CuePointCallback cuePointCallback;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Player.StatusChangeCallback statusChangeCallback;

		// Token: 0x02000134 RID: 308
		[Token(Token = "0x2000134")]
		public enum Status
		{
			// Token: 0x040005DC RID: 1500
			[Token(Token = "0x40005DC")]
			Stop,
			// Token: 0x040005DD RID: 1501
			[Token(Token = "0x40005DD")]
			Dechead,
			// Token: 0x040005DE RID: 1502
			[Token(Token = "0x40005DE")]
			WaitPrep,
			// Token: 0x040005DF RID: 1503
			[Token(Token = "0x40005DF")]
			Prep,
			// Token: 0x040005E0 RID: 1504
			[Token(Token = "0x40005E0")]
			Ready,
			// Token: 0x040005E1 RID: 1505
			[Token(Token = "0x40005E1")]
			Playing,
			// Token: 0x040005E2 RID: 1506
			[Token(Token = "0x40005E2")]
			PlayEnd,
			// Token: 0x040005E3 RID: 1507
			[Token(Token = "0x40005E3")]
			Error,
			// Token: 0x040005E4 RID: 1508
			[Token(Token = "0x40005E4")]
			StopProcessing,
			// Token: 0x040005E5 RID: 1509
			[Token(Token = "0x40005E5")]
			ReadyForRendering
		}

		// Token: 0x02000135 RID: 309
		[Token(Token = "0x2000135")]
		public enum SetMode
		{
			// Token: 0x040005E7 RID: 1511
			[Token(Token = "0x40005E7")]
			New,
			// Token: 0x040005E8 RID: 1512
			[Token(Token = "0x40005E8")]
			Append,
			// Token: 0x040005E9 RID: 1513
			[Token(Token = "0x40005E9")]
			AppendRepeatedly
		}

		// Token: 0x02000136 RID: 310
		[Token(Token = "0x2000136")]
		public enum MovieEventSyncMode
		{
			// Token: 0x040005EB RID: 1515
			[Token(Token = "0x40005EB")]
			FrameTime,
			// Token: 0x040005EC RID: 1516
			[Token(Token = "0x40005EC")]
			PlayBackTime
		}

		// Token: 0x02000137 RID: 311
		[Token(Token = "0x2000137")]
		public enum AudioTrack
		{
			// Token: 0x040005EE RID: 1518
			[Token(Token = "0x40005EE")]
			Off,
			// Token: 0x040005EF RID: 1519
			[Token(Token = "0x40005EF")]
			Auto
		}

		// Token: 0x02000138 RID: 312
		[Token(Token = "0x2000138")]
		public enum TimerType
		{
			// Token: 0x040005F1 RID: 1521
			[Token(Token = "0x40005F1")]
			None,
			// Token: 0x040005F2 RID: 1522
			[Token(Token = "0x40005F2")]
			System,
			// Token: 0x040005F3 RID: 1523
			[Token(Token = "0x40005F3")]
			Audio,
			// Token: 0x040005F4 RID: 1524
			[Token(Token = "0x40005F4")]
			User,
			// Token: 0x040005F5 RID: 1525
			[Token(Token = "0x40005F5")]
			Manual
		}

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x06000993 RID: 2451
		[Token(Token = "0x2000139")]
		public delegate void CuePointCallback(ref EventPoint eventPoint);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x06000997 RID: 2455
		[Token(Token = "0x200013A")]
		public delegate void StatusChangeCallback(Player.Status status);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x0600099B RID: 2459
		[Token(Token = "0x200013B")]
		public delegate void SubtitleChangeCallback(IntPtr subtitleBuffer);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x0600099F RID: 2463
		[Token(Token = "0x200013C")]
		public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x060009A3 RID: 2467
		[Token(Token = "0x200013D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, [In] ref EventPoint eventPoint);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x060009A7 RID: 2471
		[Token(Token = "0x200013E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void SubtitleCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2);

		// Token: 0x0200013F RID: 319
		[Token(Token = "0x200013F")]
		public enum CriManaUnityPlayer_RenderEventAction
		{
			// Token: 0x040005F7 RID: 1527
			[Token(Token = "0x40005F7")]
			UPDATE,
			// Token: 0x040005F8 RID: 1528
			[Token(Token = "0x40005F8")]
			INITIALIZE = 256,
			// Token: 0x040005F9 RID: 1529
			[Token(Token = "0x40005F9")]
			RENDER = 512,
			// Token: 0x040005FA RID: 1530
			[Token(Token = "0x40005FA")]
			DESTROY = 768
		}
	}
}
