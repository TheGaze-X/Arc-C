using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200474F RID: 18255
	[Token(Token = "0x200474F")]
	public class RecruitUpDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA4D RID: 113229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA4D")]
		[Address(RVA = "0x1506100", Offset = "0x1504D00", VA = "0x181506100")]
		public void Render(GachaDetailData.GachaUpChar upData, [Optional] List<string> limitList, [Optional] List<GachaDetailData.GachaWeightUpChar> weightUpCharList)
		{
		}

		// Token: 0x0601BA4E RID: 113230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA4E")]
		[Address(RVA = "0x1506430", Offset = "0x1505030", VA = "0x181506430")]
		public RecruitUpDetailView()
		{
		}

		// Token: 0x04023DE4 RID: 146916
		[Token(Token = "0x4023DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RecruitUpDetailObj _charObj;

		// Token: 0x04023DE5 RID: 146917
		[Token(Token = "0x4023DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecruitUpDetailObj _portObj;

		// Token: 0x04023DE6 RID: 146918
		[Token(Token = "0x4023DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023DE7 RID: 146919
		[Token(Token = "0x4023DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DE8 RID: 146920
		[Token(Token = "0x4023DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
