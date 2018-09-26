using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SwaggerUi.Models;

namespace SwaggerUi.Controllers
{
    /// <summary>
    /// 公司操作接口
    /// </summary>
    public class CompanyController : ApiController
    {
        private SwaggerEntities db = new SwaggerEntities();

        // GET: api/Company
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<Company> GetCompany()
        {
            return db.Company;
        }

        // GET: api/Company/5
        /// <summary>
        /// 根据公司的Id号获取公司信息详情
        /// </summary>
        /// <param name="id">公司的Id号</param>
        /// <returns>公司信息详情</returns>
        [ResponseType(typeof(Company))]
        public IHttpActionResult GetCompany(int id)
        {
            Company company = db.Company.Find(id);
            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        // PUT: api/Company/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompany(int id, Company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != company.Id)
            {
                return BadRequest();
            }

            db.Entry(company).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Company
        /// <summary>
        /// 
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [ResponseType(typeof(Company))]
        public IHttpActionResult PostCompany(Company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Company.Add(company);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = company.Id }, company);
        }

        // DELETE: api/Company/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(Company))]
        public IHttpActionResult DeleteCompany(int id)
        {
            Company company = db.Company.Find(id);
            if (company == null)
            {
                return NotFound();
            }

            db.Company.Remove(company);
            db.SaveChanges();

            return Ok(company);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CompanyExists(int id)
        {
            return db.Company.Count(e => e.Id == id) > 0;
        }
    }
}