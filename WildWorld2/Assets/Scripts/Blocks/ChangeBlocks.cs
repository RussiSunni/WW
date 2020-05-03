using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBlocks : MonoBehaviour
{
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    GameObject a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, CAT, DOG, OWL, BEAR;
    private bool book;
    private string sceneName;

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        sceneName = scene.name;

        book = true;
        a = GameObject.Find("a");
        b = GameObject.Find("b");
        c = GameObject.Find("c");
        d = GameObject.Find("d");
        e = GameObject.Find("e");
        f = GameObject.Find("f");
        g = GameObject.Find("g");
        h = GameObject.Find("h");
        i = GameObject.Find("i");
        j = GameObject.Find("j");
        k = GameObject.Find("k");
        l = GameObject.Find("l");
        m = GameObject.Find("m");
        n = GameObject.Find("n");
        o = GameObject.Find("o");
        p = GameObject.Find("p");
        q = GameObject.Find("q");
        r = GameObject.Find("r");
        s = GameObject.Find("s");
        t = GameObject.Find("t");
        u = GameObject.Find("u");
        v = GameObject.Find("v");
        w = GameObject.Find("w");
        x = GameObject.Find("x");
        y = GameObject.Find("y");
        z = GameObject.Find("z");

        if (sceneName == "ArtemisExercise")
        {
            CAT = GameObject.Find("CAT");
            DOG = GameObject.Find("DOG");
            OWL = GameObject.Find("OWL");
            BEAR = GameObject.Find("BEAR");
        }
    }

    private void OnMouseDown()
    {

        if (book)
        {
            book = false;

            if (A.destroyed == false && A.locked == false)
            {
                a.SetActive(false);
            }
            if (B.destroyed == false && B.locked == false)
            {
                b.SetActive(false);
            }
            if (C.destroyed == false && C.locked == false)
            {
                c.SetActive(false);
            }
            if (D.destroyed == false && D.locked == false)
            {
                d.SetActive(false);
            }
            if (E.destroyed == false && E.locked == false)
            {
                e.SetActive(false);
            }
            if (F.destroyed == false && F.locked == false)
            {
                f.SetActive(false);
            }
            if (G.destroyed == false && G.locked == false)
            {
                g.SetActive(false);
            }
            if (H.destroyed == false && H.locked == false)
            {
                h.SetActive(false);
            }
            if (I.destroyed == false && I.locked == false)
            {
                i.SetActive(false);
            }
            if (J.destroyed == false && J.locked == false)
            {
                j.SetActive(false);
            }
            if (K.destroyed == false && K.locked == false)
            {
                k.SetActive(false);
            }
            if (L.destroyed == false && L.locked == false)
            {
                l.SetActive(false);
            }
            if (M.destroyed == false && M.locked == false)
            {
                m.SetActive(false);
            }
            if (N.destroyed == false && N.locked == false)
            {
                n.SetActive(false);
            }
            if (O.destroyed == false && O.locked == false)
            {
                o.SetActive(false);
            }
            if (P.destroyed == false && P.locked == false)
            {
                p.SetActive(false);
            }
            if (Q.destroyed == false && Q.locked == false)
            {
                q.SetActive(false);
            }
            if (R.destroyed == false && R.locked == false)
            {
                r.SetActive(false);
            }
            if (S.destroyed == false && S.locked == false)
            {
                s.SetActive(false);
            }
            if (T.destroyed == false && T.locked == false)
            {
                t.SetActive(false);
            }
            if (U.destroyed == false && U.locked == false)
            {
                u.SetActive(false);
            }
            if (V.destroyed == false && V.locked == false)
            {
                v.SetActive(false);
            }
            if (W.destroyed == false && W.locked == false)
            {
                w.SetActive(false);
            }
            if (X.destroyed == false && X.locked == false)
            {
                x.SetActive(false);
            }
            if (Y.destroyed == false && Y.locked == false)
            {
                y.SetActive(false);
            }
            if (Z.destroyed == false && X.locked == false)
            {
                z.SetActive(false);
            }

            if (sceneName == "ArtemisExercise")
            {
                if (TestExerciseNext.catFlag)
                {
                    CAT.SetActive(true);
                }

                if (TestExerciseNext.dogFlag)
                {
                    DOG.SetActive(true);
                }

                if (TestExerciseNext.owlFlag)
                {
                    OWL.SetActive(true);
                }

                if (TestExerciseNext.bearFlag)
                {
                    BEAR.SetActive(true);
                }
            }
        }
        else
        {
            book = true;

            if (A.destroyed == false)
            {
                a.SetActive(true);
            }
            if (A.destroyed == false)
            {
                a.SetActive(true);
            }
            if (B.destroyed == false)
            {
                b.SetActive(true);
            }
            if (C.destroyed == false)
            {
                c.SetActive(true);
            }
            if (D.destroyed == false)
            {
                d.SetActive(true);
            }
            if (E.destroyed == false)
            {
                e.SetActive(true);
            }
            if (F.destroyed == false)
            {
                f.SetActive(true);
            }
            if (G.destroyed == false)
            {
                g.SetActive(true);
            }
            if (H.destroyed == false)
            {
                h.SetActive(true);
            }
            if (I.destroyed == false)
            {
                i.SetActive(true);
            }
            if (J.destroyed == false)
            {
                j.SetActive(true);
            }
            if (K.destroyed == false)
            {
                k.SetActive(true);
            }
            if (L.destroyed == false)
            {
                l.SetActive(true);
            }
            if (M.destroyed == false)
            {
                m.SetActive(true);
            }
            if (N.destroyed == false)
            {
                n.SetActive(true);
            }
            if (O.destroyed == false)
            {
                o.SetActive(true);
            }
            if (P.destroyed == false)
            {
                p.SetActive(true);
            }
            if (Q.destroyed == false)
            {
                q.SetActive(true);
            }
            if (R.destroyed == false)
            {
                r.SetActive(true);
            }
            if (S.destroyed == false)
            {
                s.SetActive(true);
            }
            if (T.destroyed == false)
            {
                t.SetActive(true);
            }
            if (U.destroyed == false)
            {
                u.SetActive(true);
            }
            if (V.destroyed == false)
            {
                v.SetActive(true);
            }
            if (W.destroyed == false)
            {
                w.SetActive(true);
            }
            if (X.destroyed == false)
            {
                x.SetActive(true);
            }
            if (Y.destroyed == false)
            {
                y.SetActive(true);
            }
            if (Z.destroyed == false)
            {
                z.SetActive(true);
            }

            if (sceneName == "ArtemisExercise")
            {
                CAT.SetActive(false);
                DOG.SetActive(false);
                OWL.SetActive(false);
                BEAR.SetActive(false);
            }
        }
    }
}