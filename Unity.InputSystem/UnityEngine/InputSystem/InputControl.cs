using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[DebuggerDisplay("{DebuggerDisplay(),nq}")]
	public abstract class InputControl
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700016D")]
		public string name
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x5625850", Offset = "0x5624450", VA = "0x185625850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016E")]
		public string displayName
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x5625760", Offset = "0x5624360", VA = "0x185625760")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			protected set
			{
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		public string shortDisplayName
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x5625A00", Offset = "0x5624600", VA = "0x185625A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			protected set
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000170")]
		public string path
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x56258C0", Offset = "0x56244C0", VA = "0x1856258C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000171")]
		public string layout
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x5625830", Offset = "0x5624430", VA = "0x185625830")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000172")]
		public string variants
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x5625B50", Offset = "0x5624750", VA = "0x185625B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000173")]
		public InputDevice device
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000174")]
		public InputControl parent
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x17000175")]
		public ReadOnlyArray<InputControl> children
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x5625680", Offset = "0x5624280", VA = "0x185625680")]
			get
			{
				return default(ReadOnlyArray<InputControl>);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x17000176")]
		public ReadOnlyArray<InternedString> usages
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x5625AC0", Offset = "0x56246C0", VA = "0x185625AC0")]
			get
			{
				return default(ReadOnlyArray<InternedString>);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x17000177")]
		public ReadOnlyArray<InternedString> aliases
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x5625600", Offset = "0x5624200", VA = "0x185625600")]
			get
			{
				return default(ReadOnlyArray<InternedString>);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x17000178")]
		public InputStateBlock stateBlock
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
			get
			{
				return default(InputStateBlock);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00004368 File Offset: 0x00002568
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000179")]
		public bool noisy
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x56258B0", Offset = "0x56244B0", VA = "0x1856258B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x5625BF0", Offset = "0x56247F0", VA = "0x185625BF0")]
			internal set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00004380 File Offset: 0x00002580
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017A")]
		public bool synthetic
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x5625AB0", Offset = "0x56246B0", VA = "0x185625AB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x5625D30", Offset = "0x5624930", VA = "0x185625D30")]
			internal set
			{
			}
		}

		// Token: 0x1700017B RID: 379
		[Token(Token = "0x1700017B")]
		public InputControl this[string path]
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x5625540", Offset = "0x5624140", VA = "0x185625540")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000502 RID: 1282
		[Token(Token = "0x1700017C")]
		public abstract Type valueType { [Token(Token = "0x6000502")] get; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000503 RID: 1283
		[Token(Token = "0x1700017D")]
		public abstract int valueSizeInBytes { [Token(Token = "0x6000503")] get; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x1700017E")]
		public float magnitude
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x5624820", Offset = "0x5623420", VA = "0x185624820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x56252E0", Offset = "0x5623EE0", VA = "0x1856252E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x56241A0", Offset = "0x5622DA0", VA = "0x1856241A0")]
		private string DebuggerDisplay()
		{
			return null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x5624820", Offset = "0x5623420", VA = "0x185624820")]
		public float EvaluateMagnitude()
		{
			return 0f;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "6")]
		public unsafe virtual float EvaluateMagnitude(void* statePtr)
		{
			return 0f;
		}

		// Token: 0x06000509 RID: 1289
		[Token(Token = "0x6000509")]
		public unsafe abstract object ReadValueFromBufferAsObject(void* buffer, int bufferSize);

		// Token: 0x0600050A RID: 1290
		[Token(Token = "0x600050A")]
		public unsafe abstract object ReadValueFromStateAsObject(void* statePtr);

		// Token: 0x0600050B RID: 1291
		[Token(Token = "0x600050B")]
		public unsafe abstract void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);

		// Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x5625400", Offset = "0x5624000", VA = "0x185625400", Slot = "10")]
		public unsafe virtual void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr)
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x5625470", Offset = "0x5624070", VA = "0x185625470", Slot = "11")]
		public unsafe virtual void WriteValueFromObjectIntoState(object value, void* statePtr)
		{
		}

		// Token: 0x0600050E RID: 1294
		[Token(Token = "0x600050E")]
		public unsafe abstract bool CompareValue(void* firstStatePtr, void* secondStatePtr);

		// Token: 0x0600050F RID: 1295 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x5625350", Offset = "0x5623F50", VA = "0x185625350")]
		public InputControl TryGetChildControl(string path)
		{
			return null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000510")]
		public TControl TryGetChildControl<TControl>(string path) where TControl : InputControl
		{
			return null;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x5624880", Offset = "0x5623480", VA = "0x185624880")]
		public InputControl GetChildControl(string path)
		{
			return null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000512")]
		public TControl GetChildControl<TControl>(string path) where TControl : InputControl
		{
			return null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x56254E0", Offset = "0x56240E0", VA = "0x1856254E0")]
		protected InputControl()
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		protected virtual void FinishSetup()
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x5624FD0", Offset = "0x5623BD0", VA = "0x185624FD0")]
		protected void RefreshConfigurationIfNeeded()
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		protected virtual void RefreshConfiguration()
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700017F")]
		protected internal unsafe void* currentStatePtr
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x5625700", Offset = "0x5624300", VA = "0x185625700")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000180")]
		protected internal unsafe void* previousFrameStatePtr
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x56259E0", Offset = "0x56245E0", VA = "0x1856259E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000181")]
		protected internal unsafe void* defaultStatePtr
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x5625720", Offset = "0x5624320", VA = "0x185625720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000182")]
		protected internal unsafe void* noiseMaskPtr
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x5625870", Offset = "0x5624470", VA = "0x185625870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x17000183")]
		protected internal uint stateOffsetRelativeToDeviceRoot
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x5625A50", Offset = "0x5624650", VA = "0x185625A50")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x17000184")]
		public FourCC optimizedControlDataType
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x371A2E0", Offset = "0x3718EE0", VA = "0x18371A2E0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
		protected virtual FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x5623EB0", Offset = "0x5622AB0", VA = "0x185623EB0")]
		public void ApplyParameterChanges()
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x5625260", Offset = "0x5623E60", VA = "0x185625260")]
		[MethodImpl(256)]
		private void SetOptimizedControlDataType()
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x5625020", Offset = "0x5623C20", VA = "0x185625020")]
		[MethodImpl(256)]
		internal void SetOptimizedControlDataTypeRecursively()
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x56242D0", Offset = "0x5622ED0", VA = "0x1856242D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		[MethodImpl(256)]
		internal void EnsureOptimizationTypeHasNotChanged()
		{
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00004428 File Offset: 0x00002628
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		internal bool isSetupFinished
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x5625820", Offset = "0x5624420", VA = "0x185625820")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x5625BD0", Offset = "0x56247D0", VA = "0x185625BD0")]
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00004440 File Offset: 0x00002640
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000186")]
		internal bool isButton
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x5625800", Offset = "0x5624400", VA = "0x185625800")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x5625B90", Offset = "0x5624790", VA = "0x185625B90")]
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00004458 File Offset: 0x00002658
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000187")]
		internal bool isConfigUpToDate
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x5625810", Offset = "0x5624410", VA = "0x185625810")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x5625BB0", Offset = "0x56247B0", VA = "0x185625BB0")]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00004470 File Offset: 0x00002670
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000188")]
		internal bool dontReset
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x56257D0", Offset = "0x56243D0", VA = "0x1856257D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x5625B70", Offset = "0x5624770", VA = "0x185625B70")]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00004488 File Offset: 0x00002688
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		internal bool usesStateFromOtherControl
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x5625B40", Offset = "0x5624740", VA = "0x185625B40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x5625D50", Offset = "0x5624950", VA = "0x185625D50")]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x1700018A")]
		internal bool hasDefaultState
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x56257E0", Offset = "0x56243E0", VA = "0x1856257E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x5624080", Offset = "0x5622C80", VA = "0x185624080")]
		internal void CallFinishSetupRecursive()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x5624D70", Offset = "0x5623970", VA = "0x185624D70")]
		internal string MakeChildPath(string path)
		{
			return null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x5623F50", Offset = "0x5622B50", VA = "0x185623F50")]
		internal void BakeOffsetIntoStateBlockRecursive(uint offset)
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x5624A30", Offset = "0x5623630", VA = "0x185624A30")]
		internal int GetDeviceIndex()
		{
			return 0;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x5624C10", Offset = "0x5623810", VA = "0x185624C10")]
		internal bool IsValueConsideredPressed(float value)
		{
			return default(bool);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		internal virtual void AddProcessor(object first)
		{
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x5624FC0", Offset = "0x5623BC0", VA = "0x185624FC0")]
		internal void MarkAsStale()
		{
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x5624E40", Offset = "0x5623A40", VA = "0x185624E40")]
		internal void MarkAsStaleRecursively()
		{
		}

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x10")]
		protected internal InputStateBlock m_StateBlock;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x20")]
		internal InternedString m_Name;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x30")]
		internal string m_Path;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x38")]
		internal string m_DisplayName;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x40")]
		internal string m_DisplayNameFromLayout;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x48")]
		internal string m_ShortDisplayName;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x50")]
		internal string m_ShortDisplayNameFromLayout;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x58")]
		internal InternedString m_Layout;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x68")]
		internal InternedString m_Variants;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x78")]
		internal InputDevice m_Device;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x80")]
		internal InputControl m_Parent;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x88")]
		internal int m_UsageCount;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x8C")]
		internal int m_UsageStartIndex;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x90")]
		internal int m_AliasCount;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x94")]
		internal int m_AliasStartIndex;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x98")]
		internal int m_ChildCount;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x9C")]
		internal int m_ChildStartIndex;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0xA0")]
		internal InputControl.ControlFlags m_ControlFlags;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0xA4")]
		internal bool m_CachedValueIsStale;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0xA5")]
		internal bool m_UnprocessedCachedValueIsStale;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0xA8")]
		internal PrimitiveValue m_DefaultState;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0xB8")]
		internal PrimitiveValue m_MinValue;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0xC8")]
		internal PrimitiveValue m_MaxValue;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0xD8")]
		internal FourCC m_OptimizedControlDataType;

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		[Flags]
		internal enum ControlFlags
		{
			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			ConfigUpToDate = 1,
			// Token: 0x04000279 RID: 633
			[Token(Token = "0x4000279")]
			IsNoisy = 2,
			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			IsSynthetic = 4,
			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400027B")]
			IsButton = 8,
			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400027C")]
			DontReset = 16,
			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400027D")]
			SetupFinished = 32,
			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			UsesStateFromOtherControl = 64
		}
	}
}
