using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004943 RID: 18755
	[Token(Token = "0x2004943")]
	[ExecuteInEditMode]
	public class UIMedalGroupFrame : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x0601C453 RID: 115795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004301")]
		public string groupId
		{
			[Token(Token = "0x601C453")]
			[Address(RVA = "0x15C1170", Offset = "0x15BFD70", VA = "0x1815C1170")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C454 RID: 115796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C454")]
		[Address(RVA = "0x15C0CE0", Offset = "0x15BF8E0", VA = "0x1815C0CE0")]
		public void Init(UIPage page, bool usePool = false)
		{
		}

		// Token: 0x0601C455 RID: 115797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C455")]
		[Address(RVA = "0x15C0DA0", Offset = "0x15BF9A0", VA = "0x1815C0DA0")]
		public static Sprite LoadSuitBkgSprite(UIPage page, string spriteId, bool usePool)
		{
			return null;
		}

		// Token: 0x0601C456 RID: 115798 RVA: 0x000A7BE0 File Offset: 0x000A5DE0
		[Token(Token = "0x601C456")]
		[Address(RVA = "0x15C0FA0", Offset = "0x15BFBA0", VA = "0x1815C0FA0")]
		public bool TryFindMedalPos(string medalId, out UIMedalGroupFrame.MedalPos retPos)
		{
			return default(bool);
		}

		// Token: 0x0601C457 RID: 115799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C457")]
		[Address(RVA = "0x15C0F10", Offset = "0x15BFB10", VA = "0x1815C0F10")]
		public void PopulateGraphics(List<Graphic> list)
		{
		}

		// Token: 0x0601C458 RID: 115800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C458")]
		[Address(RVA = "0x15C10C0", Offset = "0x15BFCC0", VA = "0x1815C10C0")]
		public UIMedalGroupFrame()
		{
		}

		// Token: 0x04024FBC RID: 151484
		[Token(Token = "0x4024FBC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private string _groupId;

		// Token: 0x04024FBD RID: 151485
		[Token(Token = "0x4024FBD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UIMedalGroupFrame.MedalPos> _medalPosList;

		// Token: 0x04024FBE RID: 151486
		[Token(Token = "0x4024FBE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgMesh;

		// Token: 0x04024FBF RID: 151487
		[Token(Token = "0x4024FBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x04024FC0 RID: 151488
		[Token(Token = "0x4024FC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024FC1 RID: 151489
		[Token(Token = "0x4024FC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadSuitBkgSprite;

		// Token: 0x04024FC2 RID: 151490
		[Token(Token = "0x4024FC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryFindMedalPos;

		// Token: 0x04024FC3 RID: 151491
		[Token(Token = "0x4024FC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PopulateGraphics;

		// Token: 0x04024FC4 RID: 151492
		[Token(Token = "0x4024FC4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004944 RID: 18756
		[Token(Token = "0x2004944")]
		[Serializable]
		public struct MedalPos
		{
			// Token: 0x04024FC5 RID: 151493
			[Token(Token = "0x4024FC5")]
			[FieldOffset(Offset = "0x0")]
			public string medalId;

			// Token: 0x04024FC6 RID: 151494
			[Token(Token = "0x4024FC6")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 pos;
		}
	}
}
