using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum.Models;

namespace Forum.Controllers
{ 
    public class BoardsController : Controller
    {
        private ForumDB db = new ForumDB();

        //
        // GET: /Boards/

        public ViewResult Index()
        {
            return View(db.Boards.ToList());
        }

        //
        // GET: /Boards/Details/5

        public ViewResult Details(int id)
        {
            Board board = db.Boards.Find(id);
            return View(board);
        }

        //
        // GET: /Boards/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Boards/Create

        [HttpPost]
        public ActionResult Create(Board board)
        {
            if (ModelState.IsValid)
            {
                db.Boards.Add(board);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(board);
        }
        
        //
        // GET: /Boards/Edit/5
 
        public ActionResult Edit(int id)
        {
            Board board = db.Boards.Find(id);
            return View(board);
        }

        //
        // POST: /Boards/Edit/5

        [HttpPost]
        public ActionResult Edit(Board board)
        {
            if (ModelState.IsValid)
            {
                db.Entry(board).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(board);
        }

        //
        // GET: /Boards/Delete/5
 
        public ActionResult Delete(int id)
        {
            Board board = db.Boards.Find(id);
            return View(board);
        }

        //
        // POST: /Boards/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Board board = db.Boards.Find(id);
            db.Boards.Remove(board);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


        //
        // GET: /Boards/ShowBoard/5

        public ActionResult ShowBoard(int id)
        {
            // TODO: view...
            //var m = from 

			//var p = db.Messages.Find(id).ToString;

			var x = db.Boards.Include("Messages")
					.Single(g => g.ID == id);

			return View(x);
			
        }

		public ActionResult ShowMessage(int id)
		{
			var x = db.Messages.Include("Posts")
					.Single(g => g.ID == id);

			return View(x);
		}

		public ActionResult Reply(int id)
		{
			ViewBag.MessageID = id;
			return View(new Post(id));
		}

		[HttpPost]
		public ActionResult Reply(Post post)
		{
			if (ModelState.IsValid)
			{
				post.Created = DateTime.Now;

				db.Posts.Add(post);
				db.SaveChanges();

				return RedirectToAction("Index");
			}

			return View();

		}

		public ActionResult newTopic(int id)
		{
			Message m = new Message();
			m.BoardID = id;

			return View(m);
		}

		[HttpPost]
		public ActionResult newTopic(Message message)
		{
			if (ModelState.IsValid)
			{
				message.Created = DateTime.Now;
				db.Messages.Add(message);
				db.SaveChanges();

				return RedirectToAction("showBoard", new {id = message.BoardID});
			}

			return View(message);
		}

    }
}