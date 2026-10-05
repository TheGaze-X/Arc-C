using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006082 RID: 24706
	[Token(Token = "0x2006082")]
	public class CarvingMainPage : StateEnginePage, IHotfixable
	{
		// Token: 0x17005466 RID: 21606
		// (get) Token: 0x06023BB4 RID: 146356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005466")]
		public string activityId
		{
			[Token(Token = "0x6023BB4")]
			[Address(RVA = "0x1E60EF0", Offset = "0x1E5FAF0", VA = "0x181E60EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005467 RID: 21607
		// (get) Token: 0x06023BB5 RID: 146357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005467")]
		public CarvingMainController controller
		{
			[Token(Token = "0x6023BB5")]
			[Address(RVA = "0x1E60F50", Offset = "0x1E5FB50", VA = "0x181E60F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023BB6 RID: 146358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BB6")]
		[Address(RVA = "0x1E60D20", Offset = "0x1E5F920", VA = "0x181E60D20", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06023BB7 RID: 146359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023BB7")]
		[Address(RVA = "0x1E60C70", Offset = "0x1E5F870", VA = "0x181E60C70", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06023BB8 RID: 146360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023BB8")]
		[Address(RVA = "0x1E60DD0", Offset = "0x1E5F9D0", VA = "0x181E60DD0")]
		private IEnumerator _InitStateEngine(PlayerActivity.PlayerAct35SideActivity.GameState state)
		{
			return null;
		}

		// Token: 0x06023BB9 RID: 146361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BB9")]
		[Address(RVA = "0x1E60E90", Offset = "0x1E5FA90", VA = "0x181E60E90")]
		public CarvingMainPage()
		{
		}

		// Token: 0x06023BBB RID: 146363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BBB")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06023BBC RID: 146364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023BBC")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04031871 RID: 202865
		[Token(Token = "0x4031871")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CarvingMainController _controller;

		// Token: 0x04031872 RID: 202866
		[Token(Token = "0x4031872")]
		[FieldOffset(Offset = "0xF8")]
		private string m_actId;

		// Token: 0x04031873 RID: 202867
		[Token(Token = "0x4031873")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04031874 RID: 202868
		[Token(Token = "0x4031874")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04031875 RID: 202869
		[Token(Token = "0x4031875")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04031876 RID: 202870
		[Token(Token = "0x4031876")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04031877 RID: 202871
		[Token(Token = "0x4031877")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitStateEngine;

		// Token: 0x04031878 RID: 202872
		[Token(Token = "0x4031878")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006083 RID: 24707
		[Token(Token = "0x2006083")]
		public class Params
		{
			// Token: 0x06023BBD RID: 146365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023BBD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04031879 RID: 202873
			[Token(Token = "0x4031879")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
