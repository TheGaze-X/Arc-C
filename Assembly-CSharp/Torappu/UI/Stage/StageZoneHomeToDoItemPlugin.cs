using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067F1 RID: 26609
	[Token(Token = "0x20067F1")]
	public abstract class StageZoneHomeToDoItemPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005A27 RID: 23079
		// (get) Token: 0x0602622B RID: 156203 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602622C RID: 156204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A27")]
		private protected StageZoneHomeToDoItem.PluginHandler handler
		{
			[Token(Token = "0x602622B")]
			[Address(RVA = "0x2142540", Offset = "0x2141140", VA = "0x182142540")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602622C")]
			[Address(RVA = "0x21425A0", Offset = "0x21411A0", VA = "0x1821425A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602622D RID: 156205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602622D")]
		[Address(RVA = "0x2141FD0", Offset = "0x2140BD0", VA = "0x182141FD0")]
		protected ZoneHomeToDoItemModel GetViewModel()
		{
			return null;
		}

		// Token: 0x0602622E RID: 156206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602622E")]
		[Address(RVA = "0x21420D0", Offset = "0x2140CD0", VA = "0x1821420D0")]
		public void Init(StageZoneHomeToDoItem.PluginHandler handler)
		{
		}

		// Token: 0x0602622F RID: 156207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602622F")]
		[Address(RVA = "0x21421B0", Offset = "0x2140DB0", VA = "0x1821421B0")]
		public void NotifyDataUpdated()
		{
		}

		// Token: 0x06026230 RID: 156208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026230")]
		[Address(RVA = "0x21423D0", Offset = "0x2140FD0", VA = "0x1821423D0", Slot = "4")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06026231 RID: 156209
		[Token(Token = "0x6026231")]
		protected abstract void OnDataUpdated();

		// Token: 0x06026232 RID: 156210
		[Token(Token = "0x6026232")]
		protected abstract Sprite LoadMainSprite();

		// Token: 0x06026233 RID: 156211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026233")]
		protected T LoadAsset<T>(string assetPath) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06026234 RID: 156212 RVA: 0x000CA248 File Offset: 0x000C8448
		[Token(Token = "0x6026234")]
		[Address(RVA = "0x2142430", Offset = "0x2141030", VA = "0x182142430")]
		private bool _CheckIfContentDirtry(ZoneHomeToDoItemModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06026235 RID: 156213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026235")]
		[Address(RVA = "0x21424E0", Offset = "0x21410E0", VA = "0x1821424E0")]
		protected StageZoneHomeToDoItemPlugin()
		{
		}

		// Token: 0x04035B61 RID: 220001
		[Token(Token = "0x4035B61")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedId;

		// Token: 0x04035B62 RID: 220002
		[Token(Token = "0x4035B62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_handler;

		// Token: 0x04035B63 RID: 220003
		[Token(Token = "0x4035B63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_handler;

		// Token: 0x04035B64 RID: 220004
		[Token(Token = "0x4035B64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetViewModel;

		// Token: 0x04035B65 RID: 220005
		[Token(Token = "0x4035B65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04035B66 RID: 220006
		[Token(Token = "0x4035B66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyDataUpdated;

		// Token: 0x04035B67 RID: 220007
		[Token(Token = "0x4035B67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04035B68 RID: 220008
		[Token(Token = "0x4035B68")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x04035B69 RID: 220009
		[Token(Token = "0x4035B69")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIfContentDirtry;

		// Token: 0x04035B6A RID: 220010
		[Token(Token = "0x4035B6A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
