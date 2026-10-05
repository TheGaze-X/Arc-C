using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x0200620D RID: 25101
	[Token(Token = "0x200620D")]
	public class BattleFinishIllustView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602437C RID: 148348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602437C")]
		[Address(RVA = "0x1F169A0", Offset = "0x1F155A0", VA = "0x181F169A0")]
		private void Start()
		{
		}

		// Token: 0x0602437D RID: 148349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602437D")]
		[Address(RVA = "0x1F163E0", Offset = "0x1F14FE0", VA = "0x181F163E0")]
		public void Render(BattleInfoViewModel battleInfoModel)
		{
		}

		// Token: 0x0602437E RID: 148350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602437E")]
		[Address(RVA = "0x1F16AB0", Offset = "0x1F156B0", VA = "0x181F16AB0")]
		private string _ProcessCharWordLineSplitting_LetterBase(string content, int maxLength)
		{
			return null;
		}

		// Token: 0x0602437F RID: 148351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602437F")]
		[Address(RVA = "0x1F16C40", Offset = "0x1F15840", VA = "0x181F16C40")]
		private string _ProcessCharWordLineSplitting_WordBase(string content, int maxLength)
		{
			return null;
		}

		// Token: 0x06024380 RID: 148352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024380")]
		[Address(RVA = "0x1F17410", Offset = "0x1F16010", VA = "0x181F17410")]
		private IEnumerator _UpdateWord()
		{
			return null;
		}

		// Token: 0x06024381 RID: 148353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024381")]
		[Address(RVA = "0x1F17360", Offset = "0x1F15F60", VA = "0x181F17360")]
		private IEnumerator _UpdateLayout(RectTransform rect)
		{
			return null;
		}

		// Token: 0x06024382 RID: 148354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024382")]
		[Address(RVA = "0x1F172A0", Offset = "0x1F15EA0", VA = "0x181F172A0")]
		private void _UpdateIllustTextDisplayStatus()
		{
		}

		// Token: 0x06024383 RID: 148355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024383")]
		[Address(RVA = "0x1F16F00", Offset = "0x1F15B00", VA = "0x181F16F00")]
		private static CharWordData _SelectProperCharWord(CharUISkinStruct skin, BattleInfoViewModel battleInfoModel)
		{
			return null;
		}

		// Token: 0x06024384 RID: 148356 RVA: 0x000C3798 File Offset: 0x000C1998
		[Token(Token = "0x6024384")]
		[Address(RVA = "0x1F17170", Offset = "0x1F15D70", VA = "0x181F17170")]
		private static CharWordShowType _ShowWhichCharWord(BattleInfoViewModel battleInfoModel)
		{
			return CharWordShowType.HOME_SHOW;
		}

		// Token: 0x06024385 RID: 148357 RVA: 0x000C37B0 File Offset: 0x000C19B0
		[Token(Token = "0x6024385")]
		[Address(RVA = "0x1F16A00", Offset = "0x1F15600", VA = "0x181F16A00")]
		private static CharWordShowType _CheckIsPassOrCompleted(BattleInfoViewModel battleInfoModel)
		{
			return CharWordShowType.HOME_SHOW;
		}

		// Token: 0x06024386 RID: 148358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024386")]
		[Address(RVA = "0x1F174C0", Offset = "0x1F160C0", VA = "0x181F174C0")]
		public BattleFinishIllustView()
		{
		}

		// Token: 0x040325C4 RID: 206276
		[Token(Token = "0x40325C4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _illustContainer;

		// Token: 0x040325C5 RID: 206277
		[Token(Token = "0x40325C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _illustTextContainer;

		// Token: 0x040325C6 RID: 206278
		[Token(Token = "0x40325C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _illustText;

		// Token: 0x040325C7 RID: 206279
		[Token(Token = "0x40325C7")]
		[FieldOffset(Offset = "0x30")]
		private string m_illustString;

		// Token: 0x040325C8 RID: 206280
		[Token(Token = "0x40325C8")]
		private const int MAXFRAME = 10;

		// Token: 0x040325C9 RID: 206281
		[Token(Token = "0x40325C9")]
		[FieldOffset(Offset = "0x38")]
		private UICharacterIllust m_illust;

		// Token: 0x040325CA RID: 206282
		[Token(Token = "0x40325CA")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isCurCharValid;

		// Token: 0x040325CB RID: 206283
		[Token(Token = "0x40325CB")]
		private const string CHARWORDFORMAT = "{0}<color=#FFFFFF00>{1}</color>";

		// Token: 0x040325CC RID: 206284
		[Token(Token = "0x40325CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040325CD RID: 206285
		[Token(Token = "0x40325CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040325CE RID: 206286
		[Token(Token = "0x40325CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ProcessCharWordLineSplitting_LetterBase;

		// Token: 0x040325CF RID: 206287
		[Token(Token = "0x40325CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ProcessCharWordLineSplitting_WordBase;

		// Token: 0x040325D0 RID: 206288
		[Token(Token = "0x40325D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateWord;

		// Token: 0x040325D1 RID: 206289
		[Token(Token = "0x40325D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateLayout;

		// Token: 0x040325D2 RID: 206290
		[Token(Token = "0x40325D2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateIllustTextDisplayStatus;

		// Token: 0x040325D3 RID: 206291
		[Token(Token = "0x40325D3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SelectProperCharWord;

		// Token: 0x040325D4 RID: 206292
		[Token(Token = "0x40325D4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowWhichCharWord;

		// Token: 0x040325D5 RID: 206293
		[Token(Token = "0x40325D5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIsPassOrCompleted;

		// Token: 0x040325D6 RID: 206294
		[Token(Token = "0x40325D6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
