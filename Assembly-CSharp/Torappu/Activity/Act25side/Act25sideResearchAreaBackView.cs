using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007514 RID: 29972
	[Token(Token = "0x2007514")]
	public class Act25sideResearchAreaBackView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A3D7 RID: 173015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3D7")]
		[Address(RVA = "0x25E0890", Offset = "0x25DF490", VA = "0x1825E0890")]
		public void PlayAnim()
		{
		}

		// Token: 0x0602A3D8 RID: 173016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3D8")]
		[Address(RVA = "0x25E0950", Offset = "0x25DF550", VA = "0x1825E0950")]
		public void StopAnim()
		{
		}

		// Token: 0x0602A3D9 RID: 173017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3D9")]
		[Address(RVA = "0x25E09E0", Offset = "0x25DF5E0", VA = "0x1825E09E0")]
		public Act25sideResearchAreaBackView()
		{
		}

		// Token: 0x0403CB59 RID: 248665
		[Token(Token = "0x403CB59")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403CB5A RID: 248666
		[Token(Token = "0x403CB5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x0403CB5B RID: 248667
		[Token(Token = "0x403CB5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StopAnim;

		// Token: 0x0403CB5C RID: 248668
		[Token(Token = "0x403CB5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
