using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D5B RID: 27995
	[Token(Token = "0x2006D5B")]
	public abstract class ActivityAssetHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005E5D RID: 24157
		// (get) Token: 0x06027E69 RID: 163433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E5D")]
		public string aspect
		{
			[Token(Token = "0x6027E69")]
			[Address(RVA = "0x2333FF0", Offset = "0x2332BF0", VA = "0x182333FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E5E RID: 24158
		// (get) Token: 0x06027E6A RID: 163434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E5E")]
		public string activityId
		{
			[Token(Token = "0x6027E6A")]
			[Address(RVA = "0x2333F90", Offset = "0x2332B90", VA = "0x182333F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027E6B RID: 163435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E6B")]
		[Address(RVA = "0x2333ED0", Offset = "0x2332AD0", VA = "0x182333ED0")]
		private IList _SelectableAspects()
		{
			return null;
		}

		// Token: 0x06027E6C RID: 163436
		[Token(Token = "0x6027E6C")]
		public abstract string[] GetAssetIdList();

		// Token: 0x06027E6D RID: 163437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E6D")]
		[Address(RVA = "0x2333DE0", Offset = "0x23329E0", VA = "0x182333DE0", Slot = "5")]
		protected virtual string OverriddenActId(string rawActId, string assetPath)
		{
			return null;
		}

		// Token: 0x06027E6E RID: 163438 RVA: 0x000CFDC8 File Offset: 0x000CDFC8
		[Token(Token = "0x6027E6E")]
		[Address(RVA = "0x2333E70", Offset = "0x2332A70", VA = "0x182333E70", Slot = "6")]
		protected virtual bool PrefabUpdated()
		{
			return default(bool);
		}

		// Token: 0x06027E6F RID: 163439 RVA: 0x000CFDE0 File Offset: 0x000CDFE0
		[Token(Token = "0x6027E6F")]
		[Address(RVA = "0x2333D50", Offset = "0x2332950", VA = "0x182333D50", Slot = "7")]
		protected virtual bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027E70 RID: 163440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E70")]
		[Address(RVA = "0x2333F30", Offset = "0x2332B30", VA = "0x182333F30")]
		protected ActivityAssetHolder()
		{
		}

		// Token: 0x040388DD RID: 231645
		[Token(Token = "0x40388DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Restrict("_SelectableAspects")]
		private string _aspect;

		// Token: 0x040388DE RID: 231646
		[Token(Token = "0x40388DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private string _activityId;

		// Token: 0x040388DF RID: 231647
		[Token(Token = "0x40388DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_aspect;

		// Token: 0x040388E0 RID: 231648
		[Token(Token = "0x40388E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x040388E1 RID: 231649
		[Token(Token = "0x40388E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SelectableAspects;

		// Token: 0x040388E2 RID: 231650
		[Token(Token = "0x40388E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OverriddenActId;

		// Token: 0x040388E3 RID: 231651
		[Token(Token = "0x40388E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PrefabUpdated;

		// Token: 0x040388E4 RID: 231652
		[Token(Token = "0x40388E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x040388E5 RID: 231653
		[Token(Token = "0x40388E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
